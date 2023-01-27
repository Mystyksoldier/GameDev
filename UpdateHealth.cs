using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateHealth : MonoBehaviour
{
    public Text healthCounterText;
    public PlayerHealth playerHealth;
    public int health;

    //haalt de health van de player op
    public void Update()
    {
        health = playerHealth.health;
    }

    //laat de health zien in de UI
    public void UpdateHealthCounter()
    {
        healthCounterText.text = "Health: " + health;
    }
}
