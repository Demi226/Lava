using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimmerFunction : MonoBehaviour
{

    //holds the text element and float of the timer
    public Text timeText;
    public float currentTime = 60f;

    // starts the timer when the games starts
    public bool gameStart = false;

    void Start()
    {
        timeText.text = " ";
    }

    void Update()
    {
        // while the timer is greater then zero count down
        if (currentTime > 0f && gameStart)
        {
            currentTime -= 1f * Time.deltaTime;
            timeText.text = ":" + Mathf.CeilToInt(currentTime);
        }
    }

    public void UpdateTimer()
    {
        currentTime += 10f;
        gameStart = true;
        if(currentTime >= 60f)
        {
            currentTime = 60f;
        }
    }
}
