using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    private const float MoveSpeedValue = 5f;
    private const float JumpForceValue = 5f;
    private const string HorizontalAxisName = "Horizontal";
    
    private Rigidbody2D _rigidbody2D;
    private Vector2 _movingForce;
    private Vector2 _jumpForce;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _jumpForce = new Vector2(0f, JumpForceValue);
    }

    private void Start()
    {
    }

    private void Update()
    {
        _movingForce.x = Input.GetAxis(HorizontalAxisName);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody2D.AddForce(_jumpForce, ForceMode2D.Impulse);
        }
    }
    
    private void FixedUpdate()
    {
        if (_movingForce != Vector2.zero)
        {
            transform.Translate(MoveSpeedValue * Time.fixedDeltaTime * _movingForce);
        }
    }
}   
