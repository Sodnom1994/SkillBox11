using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Animator))]
public class DoorScritpt : MonoBehaviour
{
    public Animator doorElementsAnimator;
    public Animator doorButtonCubeAnimator;
    private void Start()
    {
        if (doorElementsAnimator == null || doorButtonCubeAnimator == null)
        {
            Debug.LogError("Проверь компоненты DoorScritpt: doorElementsAnimator,doorButtonCubeAnimator");
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //Debug.Log("Player near the door");
        }
        if (other.gameObject.CompareTag("Player") && Input.GetKeyUp(KeyCode.E))
        {
            Debug.Log("Player pressed the button");
            doorButtonCubeAnimator.SetTrigger("ButtonPressed");
            doorElementsAnimator.SetTrigger("DoorTrigger");           
        }
    }
}
