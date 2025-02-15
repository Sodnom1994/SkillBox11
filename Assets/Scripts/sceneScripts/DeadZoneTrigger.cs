using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public class DeadZoneTrigger : MonoBehaviour
{
    public GameObject _gameOverPanel;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(GameOver(other));
        }
        IEnumerator GameOver(Collider other)
        {
            Destroy(other.gameObject);
            yield return new WaitForSeconds(2);
            _gameOverPanel.SetActive(true);
        }
    }
}
