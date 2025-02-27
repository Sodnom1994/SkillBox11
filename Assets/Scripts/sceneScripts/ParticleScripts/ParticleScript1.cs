using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleScript1 : MonoBehaviour
{
    public ParticleSystem _particle1;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _particle1.Play();
        }
    }
}
