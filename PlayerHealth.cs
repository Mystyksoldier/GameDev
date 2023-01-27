using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int health = 100;
    public UpdateHealth UpdateHealth;

    //geeft dammage aan de player als hij een enemy raakt
    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Enemy") {
            health -= 10;
        }
    }

    //als de health 0 is dan laad hij de scene GameLost
    void Update() {
        if (health <= 0) {
            SceneManager.LoadScene("GameLost");
        } else {
            UpdateHealth.UpdateHealthCounter();
        }
    }

}
