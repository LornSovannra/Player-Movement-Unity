using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movementX;
    public float movementSpeed = 5;
    public float jumpForce = 5;
    private string RUN_ANIMATION = "Run";
    private string JUMP_ANIMATION = "Jump";

    private Rigidbody2D _rigidbody;
    private Animator _animator;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        movementX = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movementX, 0, 0) * Time.deltaTime * movementSpeed;

        if(!Mathf.Approximately(0, movementX))
            transform.rotation = movementX < 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;

        if(Input.GetKey(KeyCode.Space) && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
        {
            _rigidbody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }


        AnimatePlayer();
    }

    void AnimatePlayer()
    {
        if(movementX > 0)
        {
            _animator.SetBool(RUN_ANIMATION, true);
        }else if(movementX < 0){
            _animator.SetBool(RUN_ANIMATION, true);
        }else
        {
            _animator.SetBool(RUN_ANIMATION, false);
        }
    }
}
