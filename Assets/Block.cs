using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    //player must have a rigidbody2D and a box colider
    private const float Speed = 7f;
    private Rigidbody2D _rigidbody2D;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        var movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * Speed;
    }

    private void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            _rigidbody2D.AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse);
        }
    }
}   
