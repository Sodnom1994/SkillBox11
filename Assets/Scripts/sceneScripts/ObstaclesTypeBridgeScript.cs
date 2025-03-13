using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(GameObject))]
public class ObstaclesTypeBridgeScript : MonoBehaviour
{
    public GameObject bridgeButtonPanel;    
    private bool isBridgeFreeze = false;
    public Animator _bridgeAnimator;
    private bool _isPlayerinBridgeZone = false;
   
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _isPlayerinBridgeZone = true;
            bridgeButtonPanel.SetActive(true);
            //Debug.Log("PlayerHere");
        }
    }
    private void OnTriggerExit(Collider other)
    {
            bridgeButtonPanel.SetActive(false);
    }
    private void Update()
    {
        if (isBridgeFreeze == true)
        {
            StartCoroutine(UnFreezeBridge());
        }
        if(_isPlayerinBridgeZone == true)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                FreezeBridge();
            }
        }
    }
    private void FreezeBridge()
    {
        isBridgeFreeze = true;
        _bridgeAnimator.speed = 0;
        //bridgeAnimation.Stop();
    }
    IEnumerator UnFreezeBridge()
    {
        yield return new WaitForSeconds(7);
        _bridgeAnimator.speed = 1;
        //bridgeAnimation.Play();
        isBridgeFreeze = false;
    }
}
