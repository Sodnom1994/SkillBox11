using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMove : MonoBehaviour
{
    private Rigidbody _sphereRB;
    private Transform _transformStart;
    private Animator _sphereAnimation;
    private void Start()
    {
        _transformStart = _sphereRB.transform;
    }

    private void Update()
    {
        if(_sphereRB.position != _transformStart.position)
        {
       
        }
    }
}
