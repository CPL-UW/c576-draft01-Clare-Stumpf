using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

public class FinMenuYearLabel : MonoBehaviour
{
    public TMP_Text labelText;
    
    // Start is called before the first frame update
    void Start()
    {
        labelText.text = "Year: " + (Manager.showHistory + 1);  

    }

    // Update is called once per frame
    void Update()
    {
        labelText.text = "Year: " + (Manager.showHistory + 1);  

    }
}
