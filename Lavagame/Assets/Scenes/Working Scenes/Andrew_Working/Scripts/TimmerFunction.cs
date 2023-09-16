using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimmerFunction : MonoBehaviour
{

    //holds the text element and float of the timer
    public Text timeText;
    public float currentTime;

    void Start()
    {
        currentTime = 60f;
    }

    void Update()
    {
        // while the timer is greater then zero count down
        if (currentTime > 0f)
        {
            currentTime -= 1f * Time.deltaTime;
            timeText.text = ":" + Mathf.CeilToInt(currentTime);
        }
    }
}
