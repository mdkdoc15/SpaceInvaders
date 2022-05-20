using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    [SerializeField] private float moveSpeed = 5f;

    private Rigidbody2D rb;
    Vector2 moveVec = Vector2.zero;


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
        rb.velocity = new Vector3(0, 0);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveVec.x = Input.GetAxisRaw("Horizontal");
        moveVec.y = Input.GetAxisRaw("Vertical");
        moveVec = moveVec.normalized;
    }

    private void FixedUpdate()
    {
        rb.velocity = moveVec * moveSpeed;
    }

    private void StopMovement()
    {
        rb.bodyType = RigidbodyType2D.Static;
    }
}
