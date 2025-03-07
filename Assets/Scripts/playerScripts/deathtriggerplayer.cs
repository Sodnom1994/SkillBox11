using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Deathtriggerplayer : MonoBehaviour
{
    public ParticleSystem deathParticleSystem;
    public GameObject player;
    private bool deathCheck = false;
    private void Update()
    {
        if (player != null)
        {
            gameObject.transform.position = player.transform.position;
        }
        else
        {
            if (!deathCheck)
            {
                deathCheck = true;
                Debug.Log("1");
                DeathParticleActive();
            }
        }
    }
    private void DeathParticleActive()
    {
        deathParticleSystem.Play();
        Debug.Log("2");
    }


}
