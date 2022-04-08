using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

public class CoveredLossesTotalLabel : MonoBehaviour
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
        if(Manager.totalLosses != 0) {
            double percent = Math.Round((double) Manager.totalLossesCovered / Manager.totalLosses, 2, MidpointRounding.ToEven);
            labelText.text = percent*100 + "%";  
        }
    }
}
