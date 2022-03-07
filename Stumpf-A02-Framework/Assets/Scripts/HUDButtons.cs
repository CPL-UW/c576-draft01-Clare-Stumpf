using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


// https://stackoverflow.com/questions/53160575/should-i-use-a-single-script-on-multiple-buttons-in-unity-or-create-a-script-fo

public class HUDButtons : MonoBehaviour
{
    public Button exitButton;
    public Button playButton;
    public Button buildingButton;
    public Button insuranceButton;
    public Button financeButton;
    public Button otherButton;

    public GameObject insuranceOptions;
    public GameObject buildingOptions;
    public GameObject financeOptions;
    public GameObject otherOptions;

    public static bool subMenuOn;
 
    public static bool GetSubMenuOn() {
        return subMenuOn;
    }

    public static void ChangeSubMenuOn(bool newState) {
        subMenuOn = newState;
    }
    // Start is called before the first frame update
    void Start()
    {
        exitButton.onClick.AddListener(() => buttonCallBack(exitButton));
        playButton.onClick.AddListener(() => buttonCallBack(playButton));
        buildingButton.onClick.AddListener(() => buttonCallBack(buildingButton));
        insuranceButton.onClick.AddListener(() => buttonCallBack(insuranceButton));
        financeButton.onClick.AddListener(() => buttonCallBack(financeButton));
        otherButton.onClick.AddListener(() => buttonCallBack(otherButton));
        subMenuOn = false;
     }

    void buttonCallBack(Button button)
    {
        if(button == exitButton) {
            SceneManager.LoadScene("MainMenu");
        }
        if(button == playButton) {
            Debug.Log("TODO: Add Play Functionality");
        }
        if(button == insuranceButton) {
            insuranceOptions.SetActive(true);
            buildingOptions.SetActive(false);
            financeOptions.SetActive(false);
            otherOptions.SetActive(false);
            subMenuOn = true;
        }
        if(button == buildingButton) {
            insuranceOptions.SetActive(false);
            buildingOptions.SetActive(true);
            financeOptions.SetActive(false);
            otherOptions.SetActive(false);    
            subMenuOn = true;    
            }
        if(button == financeButton) {
            insuranceOptions.SetActive(false);
            buildingOptions.SetActive(false);
            financeOptions.SetActive(true);
            otherOptions.SetActive(false);
            subMenuOn = true;        
            }
        if(button == otherButton) {
            insuranceOptions.SetActive(false);
            buildingOptions.SetActive(false);
            financeOptions.SetActive(false);
            otherOptions.SetActive(true);
            subMenuOn = true;        
            }
    }
}





