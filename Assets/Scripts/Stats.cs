using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    public int damage = 1;
    public float swingSpeed = 3;
    public float timeGap = 0;
    public float range = 0.5f;
    public Transform attackPoint;
    public LayerMask enemyLayers;

    private Transform target;
    

    // Update is called once per frame
    void Update()
    {
        if (timeGap > 0)
        {
            timeGap -= Time.deltaTime;
        }
        else
        {
            Attack();
            timeGap += swingSpeed;
        }
        
    }

    void Attack()
    {
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, range, enemyLayers);

        foreach (Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<Enemy>().TakeDamage(1);
        }
    }

    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
        {
            return;
        }
        Gizmos.DrawWireSphere(attackPoint.position, range);
    }
}
