using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private float lastSpawnTime;
    private GameObject foodApple;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time < lastSpawnTime + 3)
        {
            lastSpawnTime = Time.time;
        }

    }
}
