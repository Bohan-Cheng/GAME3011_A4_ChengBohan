using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class S_FollowMouse : MonoBehaviour
{
    Vector3 OriPos;
    RectTransform rect;
    // Start is called before the first frame update
    void Start()
    {
        OriPos = transform.position;
        rect = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        rect.rotation = Quaternion.Lerp(rect.rotation, Quaternion.Euler(0, 0, LookAtTarget()), 5.0f * Time.deltaTime);
        //transform.position = Vector3.Lerp(transform.position, Input.mousePosition, 1.0f * Time.deltaTime);
        transform.position += transform.right * 150.0f * Time.deltaTime;
    }


    float LookAtTarget()
    {
        float AngleRad = Mathf.Atan2(Input.mousePosition.y - transform.position.y, Input.mousePosition.x - transform.position.x);
        return 180 / Mathf.PI * AngleRad;
    }

    public void ResetPos()
    {
        transform.position = OriPos;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Finish")
        {
            SceneManager.LoadScene("Map_End");
        }
    }
}
