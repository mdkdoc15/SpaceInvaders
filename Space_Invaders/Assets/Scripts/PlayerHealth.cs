using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public static event Action OnDeath;
    
    [SerializeField] private int lives = 3;

    [SerializeField] private TextMeshProUGUI text;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Enemy"))
        {
            
            --lives;
            if (lives >= 0)
            {
                Destroy(col.gameObject);
                text.text = "Lives : " + lives.ToString();
                return;
            }
            
            OnDeath?.Invoke();
            
            
        }
    }
}
