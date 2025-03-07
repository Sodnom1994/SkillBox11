using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public CinemachineFreeLook mainCamera;
    public Transform secondTransform;
    private void Update()
    {
        if (mainCamera.Follow == null )
        {
            mainCamera.Follow = secondTransform;
            mainCamera.LookAt = secondTransform;
        }
    }
}
