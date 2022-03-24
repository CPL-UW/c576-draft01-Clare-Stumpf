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
    private String temp;
    
    // Start is called before the first frame update
    void Start()
    {
        temp = String.Format("{0:N0}", Manager.currentMoney);
        moneyText.text = "$" + temp;
    }

    public void UpdateMoneyText() {
        temp = String.Format("{0:N0}", Manager.currentMoney);
        moneyText.text = "$" + temp;
    }
    

    void Update() {
        UpdateMoneyText();
    }
 }
