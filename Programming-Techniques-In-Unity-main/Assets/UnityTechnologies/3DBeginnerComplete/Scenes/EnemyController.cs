using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField]
    private HealthSystem healthSystem;
    [SerializeField]
    private PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        //playerController.IncreaseSpeed(5f);
        //playerController.takeDamage(10);


    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            playerController.takeDamage(10);
            Debug.Log("Player has entered the trigger!");
        }    
            
         if(playerController.hp <= 0)
        {
            
            playerController.IsAlive = false;

        }
    }
}
