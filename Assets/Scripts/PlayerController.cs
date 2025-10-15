using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    private float directionY;

    public void OnMove(InputAction.CallbackContext context)
    {
        directionY = context.ReadValue<Vector2>().y;
    }

    private void Update()
    {
        transform.Translate(Vector3.up * directionY * speed * Time.deltaTime);
    }
}
