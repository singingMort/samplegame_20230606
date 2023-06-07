using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Garbage : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // ‚Ô‚Â‚©‚Á‚½‚½‚×‚à‚Ì‚ð‚·‚×‚Ä‚³‚­‚¶‚å
        Destroy(collision.gameObject);
    }
}
