using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [Tooltip("�������ɂ��ׂ��̂�����������������ق���")]
    private float lastSpawnTime;

    [Tooltip("���")]
    public GameObject apple;

    [Tooltip("����[��")]
    public GameObject grape;

    [Tooltip("�����")]
    public GameObject orange;

    [Tooltip("����")]
    public GameObject chestnut;

    [Tooltip("���ہ[��Ԃ��������")]
    public GameObject spawnPoint;

    [Tooltip("���ہ[��̂�������")]
    public Rigidbody spawnPointRigidbody;
    
    void Start()
    {
        // �Q�[�����ǂ����ɂ��ہ[��Ԃ�������݂�����ɂ��ǂ�����悤�ɂ���
        spawnPointRigidbody = spawnPoint.GetComponent<Rigidbody>();
        spawnPointRigidbody.velocity = new Vector3(1.0f, 0, 0);
    }

    
    void Update()
    {
        // �Ђ��肪��ɂƂ���������݂��ق������ɂ��ǂ�
        if (spawnPoint.transform.position.x >= 4.5f)
        {
            spawnPointRigidbody.velocity = new Vector3(-1.0f, 0, 0);
        }
        // �݂�����ɂƂ���������Ђ���ق������ɂ��ǂ�
        else if (spawnPoint.transform.position.x <= -4.5f)
        {
            spawnPointRigidbody.velocity = new Vector3(1.0f, 0, 0);
        }

        // �����т傤���񂩂��ł��ׂ��̂����ہ[��
        if (Time.time > lastSpawnTime + 1)
        {
            // 0.0����1.0�̂������Ń����_���Ȃ�����������Ƃ�����
            float randomValue = Random.value;
            GameObject spawnGameObject;

            // randomValue��0.25�����̂΂����O���[�v����������
            if (randomValue <= 0.25f)
            {
                spawnGameObject = grape;
            }
            // randomValue��0.5�����̂΂��������Ղ����������
            else if (randomValue <= 0.5f)
            {
                spawnGameObject = apple;
            }
            // randomValue��0.75�����̂΂�������񂶂���������
            else if (randomValue <= 0.75f)
            {
                spawnGameObject = orange;
            }
            // �ǂ�ɂ����Ă͂܂�Ȃ������΂����������������
            else
            {
                spawnGameObject = chestnut;
            }

            // ���ׂ��̂�������������lastSpawnTime�ɂ�����������������������ɂイ
            Transform food = Instantiate(spawnGameObject.transform, spawnPoint.transform.position, Quaternion.identity);
            food.name = spawnGameObject.name;
            lastSpawnTime = Time.time;
        }
    }
}
