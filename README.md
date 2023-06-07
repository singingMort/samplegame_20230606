# 1.かいてんするいたをつくろう
## 回転するいたを作成
![](imgs/2023-06-07-23-47-09.png)

## なまえをかいてんいたにへんこうする
![](imgs/2023-06-07-23-45-47.png)

## Add Componentをクリックしてrigidbodyをついかする
![](imgs/2023-06-07-23-49-41.png)

## scriptsフォルダをついかする
![](imgs/2023-06-07-23-49-53.png)

## scriptsフォルダをひらいてc#scriptをついかする
![](imgs/2023-06-07-23-50-07.png)

## なまえをRotatePlateにへんこうする
![](imgs/2023-06-07-23-50-21.png)

## このコードをはりつける
![](imgs/2023-06-07-23-52-52.png)


```c#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSelf : MonoBehaviour
{
    [Tooltip("ごうたい")]
    Rigidbody rigidbody;

    [Tooltip("かいてんいたのかいてんするほうこうをきめます")]
    public bool rotationDirection;

    [Tooltip("かいてんいたのかいてんそくどをきめます")]
    public float rotateSpeed = 8.0f;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // かいてんいたをかいてんさせる
        if (rotationDirection)
        {
            rigidbody.angularVelocity = Vector3.forward * rotateSpeed;
        }
        else
        {
            rigidbody.angularVelocity = Vector3.forward * -rotateSpeed;
        }
    }
}

```

## さいせいぼたんをおしてゲームをじっこうしよう
![](imgs/2023-06-07-23-53-45.png)

## かいてんしながらかいてんいたがおちてしまいます
![](imgs/2023-06-07-23-54-00.png)

## UseGravityをオンにする
![](imgs/2023-06-07-23-54-13.png)

## ブロックがそのばでかいてんするようになりました
![](imgs/2023-06-07-23-54-25.png)