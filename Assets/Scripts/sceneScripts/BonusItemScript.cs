using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusItemScript : MonoBehaviour
{
    public ParticleSystem bonusParticleSystem;
    private void OnTriggerEnter(Collider other)
    {
        bonusParticleSystem.Play();
        Destroy(this);
    }
    //IEnumerator DestroyBonusItem()
    //{
    //    yield return new WaitForSeconds(1f);
        
    //}
}
