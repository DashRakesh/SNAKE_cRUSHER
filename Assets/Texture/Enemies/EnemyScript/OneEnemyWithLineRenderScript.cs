using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneEnemyWithLineRenderScript : MonoBehaviour
{
    private LineRenderer line1;
    private Vector3 previousPosition1;
    [SerializeField] GameObject Enemy01;

    [SerializeField] private float minDistance1 = 0.1f;

    void Start()
    {
        line1 = GetComponent<LineRenderer>();
       // previousPosition1 = transform.position;
        previousPosition1 = Enemy01.transform.position;
    }

    private void Update()
    {
        //   Vector3 currentPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 currentPosition = Enemy01.transform.position;
          currentPosition.z = 0;

        if (Vector3.Distance(currentPosition, previousPosition1) > minDistance1)
        {
            line1.positionCount++;
            line1.SetPosition(line1.positionCount - 1, currentPosition);
            previousPosition1 = currentPosition;
        }
    }
}
