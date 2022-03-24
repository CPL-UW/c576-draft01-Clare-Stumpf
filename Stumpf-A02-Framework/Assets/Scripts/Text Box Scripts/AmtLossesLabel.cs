using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

public class AmtLossesLabel : MonoBehaviour
{
    public TMP_Text labelText;

    // Start is called before the first frame update
    void Start()
    {
        labelText.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        if(Manager.history[Manager.showHistory, 2] == 0) {

        } else {
            labelText.text = String.Format("{0:N1}", (double) Manager.history[Manager.showHistory,2] / 1000000) + "M";

        }

        
    }
}
