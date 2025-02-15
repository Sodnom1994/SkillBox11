using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorButtonTrigger : MonoBehaviour
{
    public Transform playerPosition;
    private float _distance;
    private float _triggerDistance = 2f;
    private bool _closeCheck;
    public Animator _buttonAnimator;
    public Animator _doorAnimator;

    private void Update()
    {
        if(playerPosition != null)
        {
            _distance = Vector3.Distance(playerPosition.position, transform.position);
        }
        if (_distance < _triggerDistance)
        {
            _closeCheck = true;
        }
        else
        {
            _closeCheck = false;
        }
        if (_closeCheck && Input.GetKeyDown(KeyCode.E))
        {
            _buttonAnimator.SetBool("ButtonPressed", true);
            _doorAnimator.SetBool("ButtonPressed", true);
        }        
    }
    public void OnAnimationEvent(AnimationEvent animationEvent)
    {
        _buttonAnimator.SetBool("ButtonPressed", false);
    }
}
