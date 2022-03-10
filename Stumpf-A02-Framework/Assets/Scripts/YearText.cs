using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

// https://gamedevbeginner.com/how-to-make-countdown-timer-in-unity-minutes-seconds/

public class YearText : MonoBehaviour
{
    public TMP_Text timeText;
    
    // Start is called before the first frame update
    void Start()
    {
        timeText.text = "Year: " + Manager.year;
    }

    public void UpdateTimeText() {
        timeText.text = "Year: " + Manager.year;
    }
    
    void Update() {
        UpdateTimeText();
    }

 }

