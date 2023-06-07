using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSelf : MonoBehaviour
{
    [Tooltip("��������")]
    Rigidbody rigidbody;
    
    [Tooltip("�����Ă񂢂��̂����Ă񂷂�ق����������߂܂�")]
    public bool rotationDirection;

    [Tooltip("�����Ă񂢂��̂����Ă񂻂��ǂ����߂܂�")]
    public float rotateSpeed = 8.0f;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // �����Ă񂢂��������Ă񂳂���
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
