using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishZoneScript : MonoBehaviour
{
    private bool _collisionDetecter = false;
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
            _collisionDetecter = false;
        }
    }
        IEnumerator TimerToNextLevel()
    {
        Debug.Log("Корутина запущена");
        yield return new WaitForSeconds(3);
        if (SceneManager.GetActiveScene().buildIndex + 1 > SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene("Main menu scene");
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
