using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [Tooltip("�X�R�A")]
    float score = 0;
    [Tooltip("�e�L�X�g�ق񂽂�")]
    public TextMeshProUGUI scoreText;
    [Tooltip("���������̂��ׂ��̂̂Ȃ܂�")]
    public string foodName = "";

    void Update()
    {
        // �e�L�X�g�ɃX�R�A���͂񂦂�������
        scoreText.text = score.ToString();
    }

    void OnCollisionEnter(Collision collision)
    {
        // �Ԃ��������ׂ��̂���������
        Destroy(collision.gameObject);

        // ���Ă��������ׂ��̂������΂����X�R�A�������񂷂�
        if (collision.transform.name == foodName)
        {
            score = score + 1;
        }
    }
}
