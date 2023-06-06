using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSelf : MonoBehaviour
{
    Rigidbody rig;

    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rig.angularVelocity = Vector3.forward * Mathf.PI;
    }
}
