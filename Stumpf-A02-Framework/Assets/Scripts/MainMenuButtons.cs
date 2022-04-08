using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//https://www.youtube.com/watch?v=76WOa6IU_s8

public class MainMenuButtons : MonoBehaviour
{
    public Button playButton;
    public Button closeButton;
    public Button closeInstructionsButton;
    public Button instructionsButton;
    public string mainScene = "SampleScene";
    public GameObject instructionsMenu;
    // Start is called before the first frame update
    void Start() {
        playButton.onClick.AddListener(() => buttonCallBack(playButton));
        instructionsButton.onClick.AddListener(() => buttonCallBack(instructionsButton));
        closeButton.onClick.AddListener(() => buttonCallBack(closeButton));
        closeInstructionsButton.onClick.AddListener(() => buttonCallBack(closeInstructionsButton));
    }

    void buttonCallBack(Button button)
    {
        if(button == playButton) {
            SceneManager.LoadScene(mainScene);
        }
        if(button == instructionsButton) {
            instructionsMenu.SetActive(true);
        }
        if(button == closeButton) {
            Application.Quit();
        }
        if(button == closeInstructionsButton) {
            instructionsMenu.SetActive(false);
            Debug.Log("Hello");
        }
    }





}
