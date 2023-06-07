using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    float score = 0;
    public TextMeshProUGUI scoreText;
    public string foodName = "";

    void Start()
    {
        // textMeshProUI = this.GetComponent<TextMeshProUGUI>();
        // textMeshProUI = transform.GetChild(0).GetChild(0).GetComponent<TextMeshPro>();
    }

    void Update()
    {
        scoreText.text = score.ToString();
    }

    void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        if (collision.transform.name == foodName)
        {
            score = score + 1;
        }
    }
}
