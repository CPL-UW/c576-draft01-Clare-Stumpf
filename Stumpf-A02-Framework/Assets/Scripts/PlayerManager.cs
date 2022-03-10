using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class PlayerManager : MonoBehaviour
{
    public int startingMoney = 1000000;
    public int currentMoney;
    public int totalMoneySpent;
    public string[] history;
    public TMP_Text moneyText;
    // Also need an array to keep track of what building they have, what insurance contranct on the buildings they have, where the buildings are, and risk profiles

    public static Sprite[] buildingSprites;
    public static int[] buildingPrices;
    public static int[] buildingRevenues;
    public static int[] damageAmounts;
    public static int[] damageProbabilities;

    public static int[] insurancePrices;
    public static int[] insuranceDeductibles;
    public static int[] insurancePremiums;

    // Start is called before the first frame update
    void Start()
    {
        currentMoney = startingMoney;
        moneyText.text = "Amount: $" + currentMoney;
        totalMoneySpent = 0;
        history = new string[10];

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
