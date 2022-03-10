using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Play : MonoBehaviour
{

    public int year;
    public TMP_Text timeText;
    public static PlayerManager player;

    // Start is called before the first frame update
    void Start()
    {
        year = 0;
        timeText.text = "Year: " + year;
        player = new PlayerManager();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 1. Board Appears with Random Geological Features
    // 2. You start out with X amount
    // 3. You can build buildings with various risk profiles
    // 4. Where you build them impacts their risk profils (fire, water, concentration)
    // 5. You can insure the buildings
    // 6. Press play and random events happen
    // 7. Results of the building

    // Building 1
    // 

        public void UpdateTime() {
        year++;
        timeText.text = "Year: " + year;
    }

    





    





















}
