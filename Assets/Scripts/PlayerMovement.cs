using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb2D;
    private PlayerControls controls;

    public float speed = 5f;

    private Vector2 moveInput;

    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
        controls = new PlayerControls();
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }

    private void Update()
    {
        moveInput = controls.Player.Move.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        rb2D.MovePosition(rb2D.position + moveInput * speed * Time.fixedDeltaTime);
    }
}