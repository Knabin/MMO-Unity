using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Tank
{
    // 온갖 정보들
    public float speed = 15.0f;
}

public class StudyPrefab : MonoBehaviour
{
    void Start()
    {
        Tank tank1 = new Tank();    // Instance를 만든다
        Tank tank2 = new Tank();    // Instance를 만든다
        Tank tank3 = new Tank();    // Instance를 만든다
        Tank tank4 = new Tank();    // Instance를 만든다
        Tank tank5 = new Tank();    // Instance를 만든다
    }

    void Update()
    {
        
    }
}
