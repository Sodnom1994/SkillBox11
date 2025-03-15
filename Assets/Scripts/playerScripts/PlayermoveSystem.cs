using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

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
            float horizontal = Input.GetAxis(GlobalStringVars.HORIZONTAL_AXIS);
            float vertical = Input.GetAxis(GlobalStringVars.VERTICAL_AXIS);
            movement = new Vector3(horizontal, 0f, vertical).normalized;
            playerRigidBody.AddForce(CameraActionTransform(horizontal, vertical) * speed);
        }
        private Vector3 CameraActionTransform(float horizontal, float vertical)
        {
            Vector3 cameraForward = cam.transform.forward;
            Vector3 cameraRight = cam.transform.right;
            cameraForward.y = 0;
            cameraRight.y = 0;
            cameraForward.Normalize();
            cameraRight.Normalize();
            Vector3 moveDirection = cameraForward * vertical + cameraRight * horizontal;
            moveDirection.Normalize();
            return moveDirection;
        }

    }
}



