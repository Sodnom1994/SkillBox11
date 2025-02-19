using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTrigger : MonoBehaviour
{
    public ParticleSystem deathAnimation;
    
    private void OnDestroy()
    {
        deathAnimation.Play();
        
    }
}
