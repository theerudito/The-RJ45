using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float _playerSpeed;

    [SerializeField]
    private Rigidbody2D _PlayerRB;

    [SerializeField]
    private Animator _animatorPlayer;

    [SerializeField]
    private SpriteRenderer _spriteRendererPlayer;

    [SerializeField]
    private bool _flipX;

    [SerializeField]
    private int direction;

    [SerializeField]
    private bool[] moveLR;

    [SerializeField]
    private bool _isRunning;

    [SerializeField]
    string directionPlayer = "Horizontal";

    void Start()
    {
        _PlayerRB = GetComponent<Rigidbody2D>();
        // _animatorPlayer = GetComponent<Animator>();
        _spriteRendererPlayer = GetComponent<SpriteRenderer>();
        moveLR = new bool[2];
    }

    void Update()
    {
        MovementPlayer();
    }

    public void MovementPlayer()
    {
        if (moveLR[0] || moveLR[1])
        {
            _PlayerRB.velocity = new Vector2(
                _playerSpeed * direction,
                _PlayerRB.velocity.y * Time.deltaTime
            );
            transform.eulerAngles = new Vector3(0, direction == 1 ? 0 : 180, 0);

            _flipX = direction == 1 ? false : true;
        }
        else
        {
            _PlayerRB.velocity = new Vector2(0, _PlayerRB.velocity.y * Time.deltaTime);
        }
    }

    public void SetDirection(int d)
    {
        if (d == 0)
        {
            moveLR[0] = false;
            moveLR[1] = false;
            _isRunning = false;
        }
        else
        {
            direction = d;
            moveLR[0] = true;
            moveLR[1] = true;
            _isRunning = true;
        }
    }
}
