using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    
    
    public void StartWave1()
    {
        SceneManager.LoadScene("Wave 1");
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
