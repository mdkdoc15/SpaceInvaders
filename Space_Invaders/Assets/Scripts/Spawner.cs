using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Hold the locations to spawn
    [SerializeField] private Transform[] spawnPositions;
    // What type to spawn
    [SerializeField] private GameObject enemy;
    
    // Time between each spawn
    [SerializeField] private float spawnTime = .5f;
    
    // What our last spawn index was
    private int index = 0;
    
    // What our last spawn time was
    private float lastTime;

    private bool isPaused = false;

    private void OnEnable()
    {
        PlayerHealth.OnDeath += Pause;
    }
    
    private void OnDisable()
    {
        PlayerHealth.OnDeath -= Pause;
    }
    private void Start()
    {
        Spawn();
    }

    private void Update()
    {
        if (Time.time - lastTime >= spawnTime)
        {
            Spawn();
        }
    }

    // Spawn an enemy at current index
    // Update time and index
    private void Spawn()
    {
        if (!isPaused)
        {
            lastTime = Time.time;
            Instantiate(enemy, spawnPositions[index].position, spawnPositions[index].rotation);
            ++index;
            // Reset index to prevent out of bounds access
            if (index >= spawnPositions.Length)
            {
                index = 0;
            }
        }
        
    }

    private void Pause()
    {
        isPaused = true;
    }
}
