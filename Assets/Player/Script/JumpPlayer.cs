using System.Collections;
using UnityEngine;

public class JumpPlayer : MonoBehaviour
{
    [SerializeField]
    private float _forceJump;

    [SerializeField]
    public float maxJumpHeight = 200f;

    [SerializeField]
    private bool isJumping = false;

    [SerializeField]
    private bool isFloor;

    [SerializeField]
    private Rigidbody2D _PlayerRB;

    [SerializeField]
    private LayerMask _groundLayer = 0;

    [SerializeField]
    private GameObject _groundCheck;

    void Start()
    {
        isFloor = true;
        _PlayerRB = GetComponent<Rigidbody2D>();
        _groundLayer = GetComponent<LayerMask>();
        _groundCheck = GetComponentInChildren<GameObject>();
        //_animatorPlayer = GetComponent<Animator>();
    }

    public void Jump()
    {
        if (isFloor)
        {
            // puede saltar

            _PlayerRB.AddForce(Vector2.up * _forceJump, ForceMode2D.Impulse);

            isJumping = true;
        }
        else
        {
            // no puede saltar
            isJumping = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log(other.collider.name);
    }
}
