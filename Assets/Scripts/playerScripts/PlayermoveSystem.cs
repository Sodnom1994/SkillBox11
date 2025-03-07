using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace WildBall.Inputs
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayermoveSystem : MonoBehaviour
    {
        private Rigidbody playerRigidBody;
        [SerializeField, Range(0, 10)] private float speed = 3.0f;
        private Vector3 movement;
        public Camera cam;
        private void Awake()
        {
            playerRigidBody = GetComponent<Rigidbody>();
        }
        void Update()
        {
            Vector3 cameraForward = cam.transform.forward;
            Vector3 cameraRight = cam.transform.right;
            cameraForward.y = 0;
            cameraRight.y = 0;
            cameraForward.Normalize();
            cameraRight.Normalize();
            float horizontal = Input.GetAxis(GlobalStringVars.HORIZONTAL_AXIS);
            float vertical = Input.GetAxis(GlobalStringVars.VERTICAL_AXIS);
            movement = new Vector3(horizontal, 0f, vertical).normalized;
            Vector3 moveDirection = cameraForward * vertical + cameraRight * horizontal;
            moveDirection.Normalize();
            playerRigidBody.AddForce(moveDirection * speed);
        }

    }
}



