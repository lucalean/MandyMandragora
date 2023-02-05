using UnityEngine;

public class MandyBehaviorScript : MonoBehaviour
{
    private float Horizontal;
    private Rigidbody2D _rigidBody;
    private bool Grounded;
    private Animator _animator;

    private float LastAttackTime;

    private int Health = 2;

    //Parameters
    [SerializeField] private float Speed = 1f;
    [SerializeField] private float JumpStrength = 10f;
    [SerializeField] private float AttackCooldown = 1f;
    [SerializeField] private BoxCollider2D _attackHitBox;
    [SerializeField] private AudioClip DeathSound;
    [SerializeField] private AudioClip JumpSound;
    [SerializeField] private AudioClip HitSound;

    void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        _attackHitBox = GetComponent<BoxCollider2D>();
        _attackHitBox.enabled = false;
    }

    void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");

        LookDirection();

        Grounded = IsTouchingFloor();

        if (GetKeyJump() && Grounded)
        {
            Jump();
        }

        if (GetKeyAttack() && CanAttack())
        {
            Attack();
            //AfterAttack();
        }
        else
        {
        }
    }

    private void FixedUpdate()
    {
        _rigidBody.velocity = new Vector2(Horizontal * Speed, _rigidBody.velocity.y);
    }

    private void Attack()
    {
        LastAttackTime = Time.time;
        _attackHitBox.enabled = true;
        _animator.SetTrigger("Attack");
        Invoke("AfterAttack", AttackCooldown);

    }

    private void AfterAttack()
    {
        _attackHitBox.enabled = false;
    }


    private bool CanAttack() => Time.time > LastAttackTime + AttackCooldown;

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
        Camera.main.GetComponent<AudioSource>().PlayOneShot(DeathSound);
        _rigidBody.AddForce(Vector2.up * JumpStrength);
    }

    private bool GetKeyJump() => Input.GetKeyDown(KeyCode.W);

    private bool GetKeyAttack() => Input.GetKeyDown(KeyCode.J);

    public void Hit(int damage)
    {
        Health -= damage;

        if (Health <= 0)
        {
            Camera.main.GetComponent<AudioSource>().PlayOneShot(DeathSound);
            Destroy(gameObject);
        }
        else
        {
            Camera.main.GetComponent<AudioSource>().PlayOneShot(HitSound);
        }

    }
}
