using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public AnimationEvent InvertBool;
    public Animator doorAnimator;
    public void OnAnimationEvent(AnimationEvent animationEvent)
    {
        doorAnimator.SetBool("ButtonPressed", false);
    }

}
