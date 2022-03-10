using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

// https://gamedevbeginner.com/how-to-make-countdown-timer-in-unity-minutes-seconds/

public class MoneyText : MonoBehaviour
{
    public TMP_Text moneyText;
    
    // Start is called before the first frame update
    void Start()
    {
        moneyText.text = "$:" + Manager.currentMoney;
    }

    public void UpdateMoneyText() {
        moneyText.text = "$:" + Manager.currentMoney;
    }

    void Update() {
        UpdateMoneyText();
    }
 }
