using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxHealth = 10;
    int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        GetComponent<Renderer>().material.color = Color.red;
        System.Threading.Thread.Sleep(500);
        GetComponent<Renderer>().material.color = Color.green;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Square is dead");
    }
}
