using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI text;

    public float timeRemaining = 120;
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            text.text = timeRemaining.ToString();
        }
        else
        {
            SceneManager.LoadScene("End");
        }
    }
}
