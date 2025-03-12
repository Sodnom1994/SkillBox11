using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishZoneScript : MonoBehaviour
{
    private bool _collisionDetecter = false;
    public GameObject winScreen;
    public ParticleSystem fireworkParticle;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _collisionDetecter = true;
        }
    }
    private void Update()
    {
        if (_collisionDetecter)
        {
            StartCoroutine(TimerToNextLevel());
            Debug.Log("Переход на след. уровень");
            Debug.Log($"SceneManager.GetActiveScene().buildIndex = {SceneManager.GetActiveScene().buildIndex}");
            Debug.Log($"SceneManager.GetActiveScene().buildIndex + 1 = {SceneManager.GetActiveScene().buildIndex + 1}");
            Debug.Log($"SceneManager.sceneCountInBuildSettings = {SceneManager.sceneCountInBuildSettings}");

            _collisionDetecter = false;
        }
    }
    IEnumerator TimerToNextLevel()
    {
        Debug.Log("Корутина запущена");
        yield return new WaitForSeconds(3);
        if (SceneManager.GetActiveScene().buildIndex + 1 == SceneManager.sceneCountInBuildSettings)
        {
            Debug.Log("!");
            winScreen.SetActive(true);
            fireworkParticle.Play();
        }
        else
        {
            Debug.Log("oops");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

}
