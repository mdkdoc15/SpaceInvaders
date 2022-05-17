using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private Transform firePos;
    [SerializeField] private GameObject projectile;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            Instantiate(projectile, firePos.position, firePos.rotation);
        }
    }
}
