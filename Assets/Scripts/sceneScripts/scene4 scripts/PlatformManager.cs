using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    public GameObject platformPrefab;
    public Vector3[] spawnPoints;
    [SerializeField]
    private List<GameObject> platforms = new List<GameObject>();
    private void Start()
    {
        CreatePlatforms();
    }
    private void CreatePlatforms()
    {
        foreach(var point in spawnPoints)
        {
            GameObject platform = Instantiate(platformPrefab, point, Quaternion.identity);
            platforms.Add(platform);
        }
    }

}
