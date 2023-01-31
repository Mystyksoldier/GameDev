using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetOrEnemy : MonoBehaviour
{
    public float health = 50f;
    private Gun gun;

    //haalt de gun op voor het geluid
    void Start()
    {
        gun = GameObject.Find("Weapon").GetComponent<Gun>();
    }
    //controleerd of je enemy genoeg health heeft en anders called die de die() functie
    public void TakeDamage (float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            gun.DieSound();
            Die();
        }
    }

    //deze functie verwijderd de enemy
    void Die()
    {
        Destroy(gameObject);
    }
}
