using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SceneManagerScript : MonoBehaviour
{        
    public void LoadScene(string nameScene)
    {
        SceneManager.LoadScene(nameScene);
    }   
}
