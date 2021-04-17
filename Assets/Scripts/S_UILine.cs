using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class S_UILine : MonoBehaviour
{
    public Vector3 StartPoint, EndPoint;
    public bool IsUsing = true;

    RectTransform rect;

    // Start is called before the first frame update
    void Start()
    {
        rect = GetComponent<RectTransform>();
        StartPoint = rect.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsUsing)
        {
            SetLine(rect.position, Input.mousePosition);
        }
    }

    public void SetLine(Vector3 start, Vector3 end)
    {
        rect.position = StartPoint = start;
        EndPoint = end;
        DrawLine();
    }


    float DistToTarget()
    {
        return Vector3.Distance(StartPoint, EndPoint);
    }

    float LookAtTarget()
    {
        float AngleRad = Mathf.Atan2(EndPoint.y - StartPoint.y, EndPoint.x - StartPoint.x);
        return 180 / Mathf.PI * AngleRad - 90;
    }

    void DrawLine()
    {
        Vector2 size = rect.sizeDelta;
        size.y = DistToTarget();
        rect.sizeDelta = size;

        rect.rotation = Quaternion.Euler(0, 0, LookAtTarget());
    }
}
