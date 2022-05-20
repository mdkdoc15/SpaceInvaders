using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.VFX;

public class BackgroundController : MonoBehaviour
{

    private Rigidbody2D rb;

    private float height;
    [SerializeField] private float scrollSpeed = 2f;

    private void OnEnable()
    {
        PlayerHealth.OnDeath += StopMovement;
    }
    
    private void OnDisable()
    {
        PlayerHealth.OnDeath -= StopMovement;
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        height = GetComponent<SpriteRenderer>().bounds.size.y;

        rb.velocity = Vector2.down * scrollSpeed;
    }

    private void Update()
    {
        if (transform.position.y < -height)
        {
            Vector2 resetPos = new Vector2(0, 2f * height);
            transform.position =  (Vector2) transform.position  + resetPos;
        }
    }

    private void StopMovement()
    {
        rb.velocity = Vector2.zero;
    }
}
