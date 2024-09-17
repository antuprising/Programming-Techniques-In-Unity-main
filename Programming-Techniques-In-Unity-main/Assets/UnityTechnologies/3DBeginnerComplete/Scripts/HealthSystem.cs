using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    // Variables for health
    public int maxHealth = 100;  // Maximum health
    private int currentHealth;   // Current health


    // Start is called before the first frame update
    void Start()
    {
        // Initialize current health to max health at the start
        currentHealth = maxHealth;
    }

    // Method to apply damage to the object
    public void TakeDamage(int damage)
    {
        // Reduce current health by damage, ensuring it doesn't go below 0
        currentHealth -= damage;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

        Debug.Log("Damage Taken: " + damage + " Current Health: " + currentHealth);

        // If health drops to 0, call Die method
        //if (currentHealth <= 0)
        //{
        //    Die();
        //}
    }
}
