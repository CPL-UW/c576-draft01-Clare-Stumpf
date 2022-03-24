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
        labelText.text = String.Format("{0:N2}", (double) Manager.totalLossesCovered / Manager.totalLosses) + "%";  

    }

    // Update is called once per frame
    void Update()
    {
        labelText.text = String.Format("{0:N2}", (double) Manager.totalLossesCovered / Manager.totalLosses + "%");  

    }
}
