using UnityEngine;

public class MandyBehaviorScript : MonoBehaviour
{
    private float Horizontal;
    private Rigidbody2D _rigidBody;
    private bool Grounded;

    //Parameters
    [SerializeField] private float Speed = 1f;
    [SerializeField] private float JumpStrength = 10f;

    void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");

        LookDirection();

        Grounded = IsTouchingFloor();

        if (Input.GetKeyDown(KeyCode.W) && Grounded)
        {
            Jump();
        }
    }

    private void LookDirection()
    {
        if (Horizontal < 0.0f)
        {
            transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
        }
        else if (Horizontal > 0.0f)
        {
            transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        }
    }

    private bool IsTouchingFloor() => Physics2D.Raycast(transform.position, Vector3.down, 0.2f);

    private void Jump()
    {
        _rigidBody.AddForce(Vector2.up * JumpStrength);
    }

    private void FixedUpdate()
    {
        _rigidBody.velocity = new Vector2(Horizontal * Speed, _rigidBody.velocity.y);
    }

}
