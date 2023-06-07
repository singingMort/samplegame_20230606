using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSelf : MonoBehaviour
{
    Rigidbody rigidbody;

    
    [Tooltip("かいてんのむききめます")]
    public bool rotationDirection;

    [Tooltip("かいてんのそくどをきめます")]
    public float rotateSpeed = 8.0f;



    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {

        if (rotationDirection)
        {
            rigidbody.angularVelocity = Vector3.forward * rotateSpeed;
        }
        else
        {
            rigidbody.angularVelocity = Vector3.forward * -rotateSpeed;
        }
        
    }
}
