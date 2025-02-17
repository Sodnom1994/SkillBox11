using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    private Animator _obstacleAnim;
    private int _randomCounterForAnimator;
    private void Awake()
    {
        _obstacleAnim = GetComponent<Animator>();
    }
    private void Start()
    {
        StartCoroutine(TimerToNewAnimation()); 
    }
    IEnumerator TimerToNewAnimation()
    {
        while (true)
        {
            _obstacleAnim.SetInteger("RandomPattern", RandomAnimationCounter());            
            yield return new WaitForSeconds(5f);
        }
    }
    private int RandomAnimationCounter()
    {
        return _randomCounterForAnimator = Random.Range(0, 3);
    }    
}
