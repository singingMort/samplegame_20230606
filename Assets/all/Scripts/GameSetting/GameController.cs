using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private float lastSpawnTime;
    // りんご
    public GameObject apple;
    // ぐれーぷ
    public GameObject grape;
    // おれんじ
    public GameObject orange;
    // くり
    public GameObject chestnut;

    public GameObject spawnPoint;
    public Rigidbody spawnPointRigidbody;


    // げーむきどうじにいっかいだけきどうする
    void Start()
    {
        spawnPointRigidbody = spawnPoint.GetComponent<Rigidbody>();
        spawnPointRigidbody.velocity = new Vector3(1.0f, 0, 0);
    }

    // まいふれーむじっこうします
    void Update()
    {
        if (spawnPoint.transform.position.x >= 4.5f)
        {
            spawnPointRigidbody.velocity = new Vector3(-1.0f, 0, 0);

        }
        else if (spawnPoint.transform.position.x <= -4.5f)
        {
            spawnPointRigidbody.velocity = new Vector3(1.0f, 0, 0);
        }


        if (Time.time > lastSpawnTime + 1)
        {
            // 0.0から1.0のあいだでランダムなあたいをしゅとくする
            float randomValue = UnityEngine.Random.value;
            Debug.Log(randomValue);
            GameObject spawnGameObject;
            if (randomValue < 0.25f)
            {
                spawnGameObject = grape;
            }
            else if (randomValue < 0.5f)
            {
                spawnGameObject = apple;
            }
            else if (randomValue < 0.75f)
            {
                spawnGameObject = orange;
            }
            else
            {
                spawnGameObject = chestnut;
            }

            Transform tmp = Instantiate(spawnGameObject.transform, spawnPoint.transform.position, Quaternion.identity);
            tmp.name = spawnGameObject.name;
            lastSpawnTime = Time.time;
        }




    }
}
