using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PauseScript : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject PausePanel;
    private void Start()
    {
        GameIsPaused = false ;
    }
    public void PauseGame()
    {
        GameIsPaused = !GameIsPaused;
        if (GameIsPaused)
        {
            Time.timeScale = 0;
            PausePanel.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            PausePanel.SetActive(false);
        }
    }
}






