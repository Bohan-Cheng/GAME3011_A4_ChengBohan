using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_UpAndDown : MonoBehaviour
{
    [SerializeField]bool moveUp = true;
    [SerializeField] float Speed = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Move());
    }

    // Update is called once per frame
    void Update()
    {

        if (moveUp)
        {

            Vector3 pos = transform.position;
            pos.y += Speed * Time.deltaTime;
            transform.position = pos;
        }
        else
        {
            Vector3 pos = transform.position;
            pos.y -= Speed * Time.deltaTime;
            transform.position = pos;
        }
    }

    IEnumerator Move()
    {
        while(true)
        {
            moveUp = !moveUp;
            yield return new WaitForSeconds(Random.Range(2.0f, 4.0f));
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<S_FollowMouse>().ResetPos();
        }
        if (collision.tag == "Wall" || collision.tag == "Device")
        {
            moveUp = !moveUp;
        }
    }
}
