using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateHealth : MonoBehaviour
{
    public Text healthCounterText;
    public PlayerHealth playerHealth;
    public int health;

    public void Update()
    {
        health = playerHealth.health;
    }

    public void UpdateHealthCounter()
    {
        healthCounterText.text = "Health: " + health;
    }
}
