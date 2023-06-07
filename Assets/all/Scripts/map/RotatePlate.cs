using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSelf : MonoBehaviour
{
    [Tooltip("‚²‚¤‚½‚¢")]
    Rigidbody rigidbody;
    
    [Tooltip("‚©‚¢‚Ä‚ñ‚¢‚½‚Ì‚©‚¢‚Ä‚ñ‚·‚é‚Ù‚¤‚±‚¤‚ð‚«‚ß‚Ü‚·")]
    public bool rotationDirection;

    [Tooltip("‚©‚¢‚Ä‚ñ‚¢‚½‚Ì‚©‚¢‚Ä‚ñ‚»‚­‚Ç‚ð‚«‚ß‚Ü‚·")]
    public float rotateSpeed = 8.0f;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // ‚©‚¢‚Ä‚ñ‚¢‚½‚ð‚©‚¢‚Ä‚ñ‚³‚¹‚é
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
