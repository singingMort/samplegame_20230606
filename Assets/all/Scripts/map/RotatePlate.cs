using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSelf : MonoBehaviour
{
    Rigidbody rigidbody;

    // �����Ă�̂ނ����߂܂�
    [Tooltip("�����Ă�̂ނ����߂܂�")]
    public bool rotationDirection;

    

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rigidbody.angularVelocity = Vector3.forward * 5.0f;
    }
}
