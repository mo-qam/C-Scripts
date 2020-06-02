using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100; // Enemy Health

    public GameObject deathEffect; // DeathEffect prefab can be added here for once the enemy is destroyed

    public void TakeDamage(int damage) // Once enemy takes damage
    {
        health -= damage;

        if (health <= 0) // If Enemy health is <=0 then it will Die
        {
            Die();
        }
    }

    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject); // Instantiates deathEffect once the enemy is destroyed 
    }
    [System.Obsolete]
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")) 
        {                                           // Once Enemy Collider collides with gameobject tagged 'Player' then a new scene will be loaded
            Application.LoadLevel("Level 4");
        }
    }
}
