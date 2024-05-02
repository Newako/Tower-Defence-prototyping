using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public float startSpeed = 10f;

    [HideInInspector]
    public float speed;

    public float startHealth = 100;
    private float health;

    public int value = 50;
    public GameObject deathVFX;

    [Header("Unity stuff")]
    public Image healthBar;

    private bool isDead = false;

    void Start()
    {
        speed = startSpeed;  
        health = startHealth;
    }

    public void TakeDamage (float amount)
    {
        health -= amount;

        healthBar.fillAmount = health / startHealth;

        if(health <= 0 & !isDead)
        {
            Die();
        }
    }

    public void Slow(float pct)
    {
        speed = startSpeed * (1f - pct);
    }

    void Die()
    {
        isDead = true;

        PlayerStats.Money += value;
        Destroy(gameObject);

        GameObject effect = Instantiate(deathVFX, transform.position, transform.rotation);
        Destroy(effect, 2f);

        WaveSpawner.EnemiesAlive--;

        Destroy(gameObject);
    }
}
