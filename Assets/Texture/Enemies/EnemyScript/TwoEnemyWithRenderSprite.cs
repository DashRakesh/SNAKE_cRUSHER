using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoEnemyWithRenderSprite : MonoBehaviour
{
    private LineRenderer line2;
    private Vector3 previousPosition2;
    [SerializeField] GameObject Enemy02;

    [SerializeField] private float minDistance1 = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        line2 = GetComponent<LineRenderer>();
        // previousPosition1 = transform.position;
        previousPosition2 = Enemy02.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //   Vector3 currentPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 currentPosition = Enemy02.transform.position;
        currentPosition.z = 0;

        if (Vector3.Distance(currentPosition, previousPosition2) > minDistance1)
        {
            line2.positionCount++;
            line2.SetPosition(line2.positionCount - 1, currentPosition);
            previousPosition2 = currentPosition;
        }

    }
}
