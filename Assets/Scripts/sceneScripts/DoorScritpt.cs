using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Animator))]
public class DoorScritpt : MonoBehaviour
{
    public Animator doorElementsAnimator;
    public Animator doorButtonCubeAnimator;
    private bool isPlayerInTrigger = false;
    private void Start()
    {
        if (doorElementsAnimator == null || doorButtonCubeAnimator == null)
        {
            Debug.LogError("Проверь компоненты DoorScritpt: doorElementsAnimator,doorButtonCubeAnimator");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isPlayerInTrigger = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        isPlayerInTrigger = false;
    }
    private void Update()
    {
        if (isPlayerInTrigger && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Player pressed the button");
            doorButtonCubeAnimator.SetTrigger("ButtonPressed");
            doorElementsAnimator.SetTrigger("DoorTrigger");
        }
    }
}
