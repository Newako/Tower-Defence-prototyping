using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 10f;
    public float startHealth;
    public GameObject deathVFX;

    private Transform target;
    private int wavepointIndex = 0;
    private float enemyHealth;

    private void Start()
    {
        target = Waypoints.waypoints[0];
        enemyHealth = startHealth;
    }

    public void TakeDamage(float amount)
    {
        enemyHealth -= amount;

        if (enemyHealth <= 0)
        {
            GameObject effect = Instantiate(deathVFX, transform.position, transform.rotation);
            Destroy(effect, 2f);

            Destroy(gameObject);
        }
    }

    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            GetNextWaypoint();
        }

        void GetNextWaypoint()
        {
            if (wavepointIndex >= Waypoints.waypoints.Length - 1)
            {
                Destroy(gameObject);
                return;
            }

            wavepointIndex++;
            target = Waypoints.waypoints[wavepointIndex];
        }
    }



}
