using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class platformScript : MonoBehaviour
{
    public Vector3 direction = Vector3.back;
    public bool loop = true;

    [SerializeField, Range(5, 25)] private float speed = 2f;
    private Transform _platformTransform;
    private Vector3 _startPos;

    private void Start()
    {
        _platformTransform = transform;
        _startPos = transform.position;
    }
    private void Update()
    {
        _platformTransform.position += direction * speed * Time.deltaTime;
        if (loop && _platformTransform.position.z < -20f)
        {
            _platformTransform.position = _startPos;
        }
    }
}
