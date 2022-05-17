using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.down * moveSpeed;
    }


    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
        }
    
        
    }
}
