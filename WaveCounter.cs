using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WaveCounter : MonoBehaviour
{
    public Text waveCounterText;
    private int waveNumber = 0;

    public void UpdateWaveNumber()
    {
        waveNumber++;
        waveCounterText.text = "Wave: " + waveNumber.ToString();
        if (waveNumber > 10)
        {
            SceneManager.LoadScene("GameWon");
        }
    }
}
