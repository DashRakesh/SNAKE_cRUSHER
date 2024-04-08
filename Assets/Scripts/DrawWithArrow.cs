using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawWithArrow : MonoBehaviour
{
    private LineRenderer line;
    private Vector3 previousPosition;
    [SerializeField] GameObject arrow;

    [SerializeField] private float minDistance = 0.1f;

     void Start()
    {
        line = GetComponent<LineRenderer>();
        previousPosition = transform.position;
    }

    private void Update()
    {
     //   Vector3 currentPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 currentPosition = arrow.transform.position;
        currentPosition.z = 0;

        if (Vector3.Distance(currentPosition, previousPosition) > minDistance)
        {
            line.positionCount++;
            line.SetPosition(line.positionCount - 1, currentPosition);
            previousPosition = currentPosition;
        }
    }
}
