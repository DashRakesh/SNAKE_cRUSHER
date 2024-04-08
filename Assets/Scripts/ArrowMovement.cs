using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMovement : MonoBehaviour
{
    public float Speed = 3.5f;

    // for rotation
    public float currentRotation;
    public float rotationSensitivity = 50.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        INPUTROTATION(); 
    }
     void FixedUpdate()
    {
        Rotation();
        MoveForward();
    }
    void INPUTROTATION()
    {
        if (Input.GetKey(KeyCode.A))
        {
            currentRotation += rotationSensitivity * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            currentRotation -= rotationSensitivity * Time.deltaTime;
        }
    }
    void MoveForward()
    {
        transform.position += transform.right * Speed * Time.fixedDeltaTime;
    }
    void Rotation()
    {
        transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, currentRotation);
    }
}
