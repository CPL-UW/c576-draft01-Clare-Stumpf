using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

public class AmtLossesTotalLabel : MonoBehaviour
{
   public TMP_Text labelText;
    
    // Start is called before the first frame update
    void Start()
    {
        if(Manager.totalLosses == 0) {
            labelText.text = "0";
        } else {
            labelText.text = String.Format("{0:N1}",  (double) Manager.totalLosses / 1000000) + "M";  
        }

    }

    // Update is called once per frame
    void Update()
    {
        if(Manager.totalLosses == 0) {
            labelText.text = "0";
        } else {
            labelText.text = String.Format("{0:N1}",  (double) Manager.totalLosses / 1000000) + "M";  
        }
    }
}
