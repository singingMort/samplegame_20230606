using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private float lastSpawnTime;
    public GameObject apple;
    public GameObject grape;
    public GameObject orange;
    public GameObject chestnut;

    public GameObject spawnPoint;
    public Rigidbody spawnPointRigidbody;


    // Start is called before the first frame update
    void Start()
    {
        spawnPointRigidbody = spawnPoint.GetComponent<Rigidbody>();
        spawnPointRigidbody.velocity = new Vector3(1.0f, 0, 0);
    }

    // Update is called once per frame


    void Update()
    {

        if (spawnPoint.transform.position.x > 5.0f)
        {
            spawnPointRigidbody.velocity = new Vector3(-1.0f, 0, 0);

        }
        else if (spawnPoint.transform.position.x < -5.0f)
        {
            spawnPointRigidbody.velocity = new Vector3(1.0f, 0, 0);
        }


        if (Time.time > lastSpawnTime + 1)
        {
            // 0.0‚©‚ç1.0‚ÌŠÔ‚Åƒ‰ƒ“ƒ_ƒ€‚È’l‚ðŽæ“¾‚·‚é
            float randomValue = UnityEngine.Random.value;

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


            Instantiate(spawnGameObject.transform, spawnPoint.transform.position, Quaternion.identity);
            lastSpawnTime = Time.time;
        }




    }
}
