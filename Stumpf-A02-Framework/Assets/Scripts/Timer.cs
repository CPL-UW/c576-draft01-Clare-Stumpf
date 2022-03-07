using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

// https://gamedevbeginner.com/how-to-make-countdown-timer-in-unity-minutes-seconds/

public class Timer : MonoBehaviour
{
    public float timeValue;
    public TMP_Text timeText;
    
    // Start is called before the first frame update
    void Start()
    {
        timeValue = 0;
        timeText.text = "Year: " + timeValue;
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    // Have some code later that increases the number of years or something
    public void UpdateTime(float timeElapsed) {
        timeValue += timeElapsed;
        timeText.text = "Year: " + timeValue;
        
    }

 }
