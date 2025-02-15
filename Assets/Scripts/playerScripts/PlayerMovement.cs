using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace WildBall.Inputs
{
    [RequireComponent(typeof(Rigidbody))] //Проверка наличия у GameObject Rigidbody компонента
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField, Range(0, 10)] private float Speed = 2.0f;
        private Rigidbody _playerRigidbody;

        private void Awake()
        {
            _playerRigidbody = GetComponent<Rigidbody>();
        }
        public void MovePlayer(Vector3 movement)
        {
            _playerRigidbody.AddForce(movement * Speed);
        }
#if UNITY_EDITOR
        [ContextMenu("Reset values")]
        public void ResetValues()
        {
            Speed = 2;
        }
#endif

    }
}

