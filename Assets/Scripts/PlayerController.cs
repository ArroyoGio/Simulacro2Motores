using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    private float directionY;

    public int puntos = 0;

    public void OnMove(InputAction.CallbackContext context)
    {
        directionY = context.ReadValue<Vector2>().y;
    }

    private void Update()
    {
        transform.Translate(Vector3.up * directionY * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Candy")
        {
            puntos = puntos + 10;
            Destroy(collision.gameObject);
            Debug.Log("Puntos: " + puntos);
        }
    }
}
