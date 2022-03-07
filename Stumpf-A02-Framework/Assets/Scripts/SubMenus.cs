using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubMenus : MonoBehaviour
{

    public Button insuranceExit;
    public Button buildingExit;
    public Button financeExit;
    public Button otherExit;

    public GameObject insuranceOptions;
    public GameObject buildingOptions;
    public GameObject financeOptions;
    public GameObject otherOptions;
    // Start is called before the first frame update

    public Button buildingOpt1;
    public Button buildingOpt2;
    public Button buildingOpt3;

    private static int addBuilding;
    
    void Start()
    {
        insuranceExit.onClick.AddListener(() => buttonCallBack(insuranceExit));
        buildingExit.onClick.AddListener(() => buttonCallBack(buildingExit));
        financeExit.onClick.AddListener(() => buttonCallBack(financeExit));
        otherExit.onClick.AddListener(() => buttonCallBack(otherExit));

        buildingOpt1.onClick.AddListener(() => buttonCallBack(buildingOpt1));        
        buildingOpt2.onClick.AddListener(() => buttonCallBack(buildingOpt2));        
        buildingOpt3.onClick.AddListener(() => buttonCallBack(buildingOpt3));        

       
        addBuilding = 0;
    }

    public static int GetAddBuilding() {
        return addBuilding;
    }

    public static void ChangeAddBuilding() {
        addBuilding = 0;
    }

    void buttonCallBack(Button button)
    {
        if(button == insuranceExit) {
            insuranceOptions.SetActive(false);
            HUDButtons.ChangeSubMenuOn(false);

        }
        if(button == buildingExit) {
            buildingOptions.SetActive(false);
            HUDButtons.ChangeSubMenuOn(false);
        }
        if(button == financeExit) {
            financeOptions.SetActive(false);
            HUDButtons.ChangeSubMenuOn(false);
        }
        if(button == otherExit) {
            otherOptions.SetActive(false);
            HUDButtons.ChangeSubMenuOn(false);
        }
        
        if(button == buildingOpt1) {
            buildingOptions.SetActive(false);
            HUDButtons.ChangeSubMenuOn(false);
            addBuilding = 1;
        }
        if(button == buildingOpt2) {
            buildingOptions.SetActive(false);
            HUDButtons.ChangeSubMenuOn(false);
            addBuilding = 2;
        }
        if(button == buildingOpt3) {
            buildingOptions.SetActive(false);
            HUDButtons.ChangeSubMenuOn(false);
            addBuilding = 3;
        }

    }
}
