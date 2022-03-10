using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Manager : MonoBehaviour
{
    // Variables Relating to the Main HUD
    public Button exitButton;
    public Button playButton;
    public Button buildingButton;
    public Button insuranceButton;
    public Button financeButton;
    public Button otherButton;
    public GameObject insuranceMenu;
    public GameObject buildingMenu;
    public GameObject financeMenu;
    public GameObject otherMenu;
    public TMP_Text timeText;
    public TMP_Text moneyText;

    public static bool disableGrid;

    // Variables Relating to the SubMenus
    public Button insuranceExit;
    public Button buildingExit;
    public Button financeExit;
    public Button otherExit;
    public Button buildingOpt1;
    public Button buildingOpt2;
    public Button buildingOpt3;
    public Button insuranceOpt1;
    public Button insuranceOpt2;
    public Button insuranceOpt3;


    private static int addBuilding;

    // Variables relating to the Building and Insurance Options
    public static int[] buildingPrices;
    public static int[] buildingRevenues;
    public static int[] damageAmounts;
    public static int[,] damageProbabilities;
    public static int[] insuranceDeductibles;
    public static int[] insurancePremiums;
    public static int totalYears;

    // Variables to keep track of player information
    public static int year;
    public static int startingMoney;
    public static int currentMoney;
    public static int totalMoneySpent;
    public static int numLosses;
    public static int totalNumLosses;
    public static int losses;
    public static int totalLosses;
    public static int lossesCovered;
    public static int totalLossesCovered;
    public static int revenue;
    public static int totalRevenue;
    public static ArrayList buildingsPurchased;
    public static ArrayList buildTypePurchased;
    public static ArrayList insurancePurchased;

    // Total Losses, Total Revenue Generated, Total Premiums Paid
    public static string[] history;
    // Also need an array to keep track of what building they have, what insurance contranct on the buildings they have, where the buildings are, and risk profiles


    void Start() {
        // HUD
        exitButton.onClick.AddListener(() => buttonCallBack(exitButton));
        playButton.onClick.AddListener(() => buttonCallBack(playButton));
        buildingButton.onClick.AddListener(() => buttonCallBack(buildingButton));
        insuranceButton.onClick.AddListener(() => buttonCallBack(insuranceButton));
        financeButton.onClick.AddListener(() => buttonCallBack(financeButton));
        otherButton.onClick.AddListener(() => buttonCallBack(otherButton));

        // SubMenus
        insuranceExit.onClick.AddListener(() => buttonCallBack(insuranceExit));
        buildingExit.onClick.AddListener(() => buttonCallBack(buildingExit));
        financeExit.onClick.AddListener(() => buttonCallBack(financeExit));
        otherExit.onClick.AddListener(() => buttonCallBack(otherExit));
        buildingOpt1.onClick.AddListener(() => buttonCallBack(buildingOpt1));        
        buildingOpt2.onClick.AddListener(() => buttonCallBack(buildingOpt2));        
        buildingOpt3.onClick.AddListener(() => buttonCallBack(buildingOpt3));
        insuranceOpt1.onClick.AddListener(() => buttonCallBack(insuranceOpt1));        
        insuranceOpt2.onClick.AddListener(() => buttonCallBack(insuranceOpt2));        
        insuranceOpt3.onClick.AddListener(() => buttonCallBack(insuranceOpt3));            
       
        addBuilding = 0;
        disableGrid = false;

        buildingPrices = new int[] {300000, 500000, 600000};
        buildingRevenues = new int[] {400000, 300000, 350000};
        damageAmounts = new int[] {0, 100000, 500000, 1000000};
        damageProbabilities = new int[,] {{50, 40, 8, 2}, {63, 30, 6, 2}, {76, 19, 4, 1}};
        insurancePremiums = new int[] {0, 71000, 20000};
        // Deductible for No insurance is technically infinity
        insuranceDeductibles = new int[] {10000000, 50000, 500000};
        totalYears = 2;

        year = 0;
        startingMoney = 1000000;
        currentMoney = startingMoney;
        buildingsPurchased = new ArrayList();
        buildTypePurchased = new ArrayList();
        insurancePurchased = new ArrayList();
        totalMoneySpent = 0;
        numLosses = 0;
        totalNumLosses = 0;
        losses = 0;
        totalLosses = 0;
        lossesCovered = 0;
        totalLossesCovered = 0;
        revenue = 0;
        totalRevenue = 0;
        // history;
    }

    public static void ToggleMenu(GameObject subMenu) {
        if(subMenu.activeSelf == true) {
            subMenu.SetActive(false);
        } else {
            subMenu.SetActive(true);
        }
    }
    
    void buttonCallBack(Button button)
    {
        if(button == exitButton) {
            SceneManager.LoadScene("MainMenu");
        }
        if(button == playButton) {
            PlayYear();
        }
        if(button == insuranceButton) {
            ToggleMenu(insuranceMenu);            
            buildingMenu.SetActive(false);
            financeMenu.SetActive(false);
            otherMenu.SetActive(false);
            disableGrid = true;
        }
        if(button == buildingButton) {
            ToggleMenu(buildingMenu);            
            insuranceMenu.SetActive(false);
            buildingMenu.SetActive(true);
            financeMenu.SetActive(false);
            otherMenu.SetActive(false);    
            disableGrid = true;    
        }
        if(button == financeButton) {
            ToggleMenu(financeMenu);            
            insuranceMenu.SetActive(false);
            buildingMenu.SetActive(false);
            financeMenu.SetActive(true);
            otherMenu.SetActive(false);
            disableGrid = true;        
        }
        if(button == otherButton) {
            ToggleMenu(otherMenu);            
            insuranceMenu.SetActive(false);
            buildingMenu.SetActive(false);
            financeMenu.SetActive(false);
            otherMenu.SetActive(true);
            disableGrid = true;        
        }
        if(button == insuranceExit) {
            insuranceMenu.SetActive(false);
            ChangeDisableGrid(false);

        }
        if(button == buildingExit) {
            buildingMenu.SetActive(false);
            ChangeDisableGrid(false);
        }
        if(button == financeExit) {
            financeMenu.SetActive(false);
            ChangeDisableGrid(false);
        }
        if(button == otherExit) {
            otherMenu.SetActive(false);
            ChangeDisableGrid(false);
        }
        
        if(button == buildingOpt1) {
            buildingMenu.SetActive(false);
            ChangeDisableGrid(false);
            addBuilding = 1;
        }
        if(button == buildingOpt2) {
            buildingMenu.SetActive(false);
            ChangeDisableGrid(false);
            addBuilding = 2;
        }
        if(button == buildingOpt3) {
            buildingMenu.SetActive(false);
            ChangeDisableGrid(false);
            addBuilding = 3;
        }

        if(button == insuranceOpt1) {
            AddInsurance(0);
            insuranceMenu.SetActive(false);
            ChangeDisableGrid(false);
        }
        if(button == insuranceOpt2) {
            AddInsurance(1);
            insuranceMenu.SetActive(false);
            ChangeDisableGrid(false);
        }
        if(button == insuranceOpt3) {
            AddInsurance(2);
            insuranceMenu.SetActive(false);
            ChangeDisableGrid(false);
        }

    }

    public static int GetAddBuilding() {
        return addBuilding;
    }

    public static void ChangeAddBuilding() {
        addBuilding = 0;
    }

    public static bool GetDisableGrid() {
        return disableGrid;
    }

    public static void ChangeDisableGrid(bool newState) {
        disableGrid = newState;
    }
    
    public static void AddInsurance(int ins) {
        currentMoney -= insurancePremiums[ins];
        insurancePurchased.Add(ins);
    }

    private static void PlayYear() {
        // Have Random Events Happen
        for (int i = 0; i < buildTypePurchased.Count; i++) {
            var rand = Random.Range(0,100);
            currentMoney += buildingRevenues[(int)buildTypePurchased[i]];
            revenue += buildingRevenues[(int)buildTypePurchased[i]];
            totalRevenue += buildingRevenues[(int)buildTypePurchased[i]];

            if(rand < damageProbabilities[(int)buildTypePurchased[i],0]) {
                // Nothing Happens - Loss of 0

            } else if(rand < damageProbabilities[(int)buildTypePurchased[i],0]) {
                losses += damageAmounts[1];
                totalLosses += damageAmounts[1];
                numLosses++;
                totalNumLosses++;
                // If the amount is less than the deductible, they pay the entire amount
                if(damageAmounts[1] < insuranceDeductibles[(int)insurancePurchased[i]]) {
                    currentMoney -= damageAmounts[1];
                } else {
                    currentMoney -= insuranceDeductibles[(int) insurancePurchased[i]];
                    lossesCovered += damageAmounts[1] - insuranceDeductibles[(int) insurancePurchased[i]];
                    totalLossesCovered += damageAmounts[1] - insuranceDeductibles[(int) insurancePurchased[i]];

                }
                
            } else if(rand < damageProbabilities[(int)buildTypePurchased[i],0]) {
                losses += damageAmounts[2];
                totalLosses += damageAmounts[2];
                numLosses++;
                totalNumLosses++;
                // If the amount is less than the deductible, they pay the entire amount
                if(damageAmounts[2] < insuranceDeductibles[(int)insurancePurchased[i]]) {
                    currentMoney -= damageAmounts[2];
                } else {
                    currentMoney -= insuranceDeductibles[(int)insurancePurchased[i]];
                    lossesCovered += damageAmounts[2] - insuranceDeductibles[(int) insurancePurchased[i]];
                    totalLossesCovered += damageAmounts[2] - insuranceDeductibles[(int) insurancePurchased[i]];

                } 
            } else {
                losses += damageAmounts[3];
                totalLosses += damageAmounts[3];
                numLosses++;
                totalNumLosses++;
                // If the amount is less than the deductible, they pay the entire amount
                if(damageAmounts[3] < insuranceDeductibles[(int)insurancePurchased[i]]) {
                    currentMoney -= damageAmounts[3];
                } else {
                    currentMoney -= insuranceDeductibles[(int)insurancePurchased[i]];
                    lossesCovered += damageAmounts[3] - insuranceDeductibles[(int) insurancePurchased[i]];
                    totalLossesCovered += damageAmounts[3] - insuranceDeductibles[(int) insurancePurchased[i]];

                }
            }
        }

        // Create Summary of What Happened
        Debug.Log("Current Money: " + currentMoney);
        Debug.Log("Revenue: " + revenue);

        Debug.Log("Num Losses: " + numLosses);
        Debug.Log("Losses: " + losses);
        Debug.Log("Losses Covered: " + lossesCovered);
        Debug.Log("Total Revenue:  " + totalRevenue);

        Debug.Log("Total Num Losses: " + totalNumLosses);
        Debug.Log("Total Losses: " + totalLosses);
        Debug.Log("Total Losses Covered: " + totalLossesCovered);

        if(year == totalYears) {
            // TODO: Game Over Scene
            if(currentMoney > startingMoney) {
                Debug.Log("You Win! Score:" + (currentMoney - startingMoney));
            } else {
                Debug.Log("You Lose!");
            }
        } else {
            losses = 0;
            lossesCovered = 0;
            numLosses = 0;
            year++;

        }
    }

}
