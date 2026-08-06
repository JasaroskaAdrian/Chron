using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb2D;
    private PlayerControls controls;

    [SerializeField] private float walkSpeed = 5f;
    [SerializeField] private float sprintMultiplier = 1.75f;

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
        // This reads what the User is inputting and storing the current button to moveInput
        moveInput = controls.Player.Move.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        float currentSpeed = walkSpeed;

        if (controls.Player.Sprint.IsPressed())
        {
            currentSpeed *= sprintMultiplier;
        }
        rb2D.MovePosition(rb2D.position + moveInput * currentSpeed * Time.fixedDeltaTime);
        Debug.Log(currentSpeed);
    }
}