using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [Tooltip("スコア")]
    float score = 0;
    [Tooltip("テキストほんたい")]
    public TextMeshProUGUI scoreText;
    [Tooltip("せいかいのたべもののなまえ")]
    public string foodName = "";

    void Update()
    {
        // テキストにスコアをはんえいさせる
        scoreText.text = score.ToString();
    }

    void OnCollisionEnter(Collision collision)
    {
        // ぶつかったたべものをさくじょ
        Destroy(collision.gameObject);

        // していしたたべものだったばあいスコアをかさんする
        if (collision.transform.name == foodName)
        {
            score = score + 1;
        }
    }
}
