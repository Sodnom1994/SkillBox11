using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathtriggerplayer : MonoBehaviour
{
    public ParticleSystem ParticleSystem;
    private void Start()
    {
        if(ParticleSystem==null)
        {
            Debug.LogError("Проверь компонент");
        }    
    }
    private void OnDestroy()
    {
        ParticleSystem.Play();
    }
}
