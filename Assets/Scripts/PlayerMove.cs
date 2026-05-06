using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D rb2d;
    [SerializeField] private float speed;
    [SerializeField] private InputActionReference moveInput;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Vector2 move= moveInput.action.ReadValue<Vector2>();
        rb2d.linearVelocity = move.normalized * speed;
    }
}
