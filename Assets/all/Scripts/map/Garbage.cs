using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Garbage : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // �Ԃ��������ׂ��̂����ׂĂ�������
        Destroy(collision.gameObject);
    }
}
