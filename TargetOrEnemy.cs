using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetOrEnemy : MonoBehaviour
{
    public float health = 50f;

    //controleerd of je enemy genoeg health heeft en anders called die de die() functie
    public void TakeDamage (float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }

    //deze functie verwijderd de enemy
    void Die()
    {
        Destroy(gameObject);
    }
}
