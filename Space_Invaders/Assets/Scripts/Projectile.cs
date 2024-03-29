using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
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
    }

    private void Start()
    {
        rb.velocity = Vector2.up * moveSpeed;
    }
    
    private void StopMovement()
    {
        rb.velocity = Vector2.zero;
    }
}
