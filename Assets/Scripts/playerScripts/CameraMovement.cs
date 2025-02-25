using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    private Vector3 offset;

    private void Start()
    {
        offset = transform.position - playerTransform.position;
    }
    private void FixedUpdate()
    {
        if (playerTransform != null)
        {
            transform.position = playerTransform.position + offset;
        }
    }
}
