﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudyRotation : MonoBehaviour
{
    [SerializeField]
    float _speed = 10.0f;

    void Start()
    {

    }

    float _yAngle = 0.0f;
    void Update()
    {
        _yAngle += Time.deltaTime * 100.0f;

        // += delta
        //transform.Rotate(new Vector3(0.0f, Time.deltaTime * 100.0f, 0.0f));

        //transform.rotation = Quaternion.Euler(new Vector3(0.0f, Time.deltaTime * 100.0f, 0.0f));

        if (Input.GetKey(KeyCode.W))
        {
            //transform.Translate(Vector3.forward * Time.deltaTime * _speed);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.forward), 0.2f);
            transform.position += Vector3.forward * Time.deltaTime * _speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            //transform.Translate(Vector3.back * Time.deltaTime * _speed);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.back), 0.2f);
            transform.position += Vector3.back * Time.deltaTime * _speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            //transform.Translate(Vector3.left * Time.deltaTime * _speed);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.left), 0.2f);
            transform.position += Vector3.left * Time.deltaTime * _speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            //transform.Translate(Vector3.right * Time.deltaTime * _speed);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.right), 0.2f);
            transform.position += Vector3.right * Time.deltaTime * _speed;
        }
    }
}
