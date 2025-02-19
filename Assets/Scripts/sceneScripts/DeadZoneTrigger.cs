using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public class DeadZoneTrigger : MonoBehaviour
{
    public GameObject gameOverPanel;
    public ParticleSystem deathParticle;

    private void Start()
    {
        if(gameOverPanel == null || deathParticle ==null)
        {
            Debug.LogError("Проверь компонент у объекта");
        }    
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(GameOver(other));
        }
        IEnumerator GameOver(Collider other)
        {
            deathParticle.Play();
            Destroy(other.gameObject);
            yield return new WaitForSeconds(2);
            gameOverPanel.SetActive(true);
        }
    }
}
