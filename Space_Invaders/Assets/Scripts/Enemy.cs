using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public static event Action Score;
    
    [SerializeField] private float moveSpeed = 5f;

    private Rigidbody2D rb;
    
    
    private void OnEnable()
    {
        PlayerHealth.OnDeath += StopMovement;
    }
    
    private void OnDisable()
    {
        PlayerHealth.OnDeath -= StopMovement;
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.down * moveSpeed;
    }


   

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Bullet"))
        {
            Score?.Invoke();
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
    
    private void StopMovement()
    {
        rb.velocity = Vector2.zero;
    }
}
