using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Deathtriggerplayer : MonoBehaviour
{
    public ParticleSystem ParticleSystem;
    private void Start()
    {
        if (ParticleSystem == null)
        {
            Debug.LogError("Проверь компонент");
        }
    }
    private void OnDestroy()
    {

        Debug.Log("!");
        ParticleSystem.Play();

    }

}
