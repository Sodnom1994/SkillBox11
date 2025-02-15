using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
namespace WildBall.Inputs
{
    [RequireComponent(typeof(PlayerMovement))]
    public class PlayerController : MonoBehaviour
    {        
        private Vector3 movement;
        private float horizontalInput;
        private float verticalInput;
        private PlayerMovement playerMovement;
        private void Awake()
        {
            playerMovement = GetComponent<PlayerMovement>();
        }
        private void Update()
        {
            horizontalInput = Input.GetAxis(GlobalStringVars.HORIZONTAL_AXIS);
            verticalInput = Input.GetAxis(GlobalStringVars.VERTICAL_AXIS);

            movement = new Vector3(horizontalInput, 0, verticalInput).normalized;
        }
        private void FixedUpdate()
        {
            playerMovement.MovePlayer(movement);
        }       
    }
}

