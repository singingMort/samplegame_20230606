using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private float lastSpawnTime;
    public GameObject foodApple;
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
            Instantiate(foodApple, spawnPoint.transform.position, Quaternion.identity);
            lastSpawnTime = Time.time;
        }




    }
}
