using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManagment : MonoBehaviour
{
    [SerializeField] private GameObject gameOverScreen;
   
    
    public void EnableGameOverMenu()
    {
        gameOverScreen.SetActive(true);
    }

    

    public void OnEnable()
    {
        PlayerHealth.OnDeath += EnableGameOverMenu;
    }
    
    public void OnDisable()
    {
        PlayerHealth.OnDeath -= EnableGameOverMenu;
    }
}
