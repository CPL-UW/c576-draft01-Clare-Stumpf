using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

public class NumLossesLabel : MonoBehaviour
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
        if(Manager.year == 0) {

        } else {
            labelText.text = String.Format("{0:N0}", Manager.history[Manager.showHistory,1]);

        }

        
    }
}
