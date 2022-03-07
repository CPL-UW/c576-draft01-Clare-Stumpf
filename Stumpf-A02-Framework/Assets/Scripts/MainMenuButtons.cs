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
    public Button optionsButton;
    public string mainScene = "SampleScene";
    // Start is called before the first frame update
    void Start() {
        playButton.onClick.AddListener(() => buttonCallBack(playButton));
        optionsButton.onClick.AddListener(() => buttonCallBack(optionsButton));
        closeButton.onClick.AddListener(() => buttonCallBack(closeButton));
    }

    void buttonCallBack(Button button)
    {
        if(button == playButton) {
            SceneManager.LoadScene(mainScene);
        }
        if(button == optionsButton) {
            Debug.Log("TODO: Add Options Menu");
        }
        if(button == closeButton) {
            Application.Quit();
        }
    }





}
