using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [Tooltip("さいごにたべものをせいせいじかんをほぞん")]
    private float lastSpawnTime;

    [Tooltip("りんご")]
    public GameObject apple;

    [Tooltip("ぐれーぷ")]
    public GameObject grape;

    [Tooltip("おれんじ")]
    public GameObject orange;

    [Tooltip("くり")]
    public GameObject chestnut;

    [Tooltip("すぽーんぶろっくいち")]
    public GameObject spawnPoint;

    [Tooltip("すぽーんのごうたい")]
    public Rigidbody spawnPointRigidbody;
    
    void Start()
    {
        // ゲームきどうじにすぽーんぶろっくがみぎがわにいどうするようにする
        spawnPointRigidbody = spawnPoint.GetComponent<Rigidbody>();
        spawnPointRigidbody.velocity = new Vector3(1.0f, 0, 0);
    }

    
    void Update()
    {
        // ひだりがわにとうたつしたらみぎほうこうにいどう
        if (spawnPoint.transform.position.x >= 4.5f)
        {
            spawnPointRigidbody.velocity = new Vector3(-1.0f, 0, 0);
        }
        // みぎがわにとうたつしたらひだりほうこうにいどう
        else if (spawnPoint.transform.position.x <= -4.5f)
        {
            spawnPointRigidbody.velocity = new Vector3(1.0f, 0, 0);
        }

        // いちびょうかんかくでたべものをすぽーん
        if (Time.time > lastSpawnTime + 1)
        {
            // 0.0から1.0のあいだでランダムなあたいをしゅとくする
            float randomValue = Random.value;
            GameObject spawnGameObject;

            // randomValueが0.25いかのばあいグレープをせいせい
            if (randomValue <= 0.25f)
            {
                spawnGameObject = grape;
            }
            // randomValueが0.5いかのばあいあっぷるをせいせい
            else if (randomValue <= 0.5f)
            {
                spawnGameObject = apple;
            }
            // randomValueが0.75いかのばあいおれんじをせいせい
            else if (randomValue <= 0.75f)
            {
                spawnGameObject = orange;
            }
            // どれにもあてはまらなかったばあいくりをせいせい
            else
            {
                spawnGameObject = chestnut;
            }

            // たべものをせいせいしてlastSpawnTimeにせいせいしたじかんをだいにゅう
            Transform food = Instantiate(spawnGameObject.transform, spawnPoint.transform.position, Quaternion.identity);
            food.name = spawnGameObject.name;
            lastSpawnTime = Time.time;
        }
    }
}
