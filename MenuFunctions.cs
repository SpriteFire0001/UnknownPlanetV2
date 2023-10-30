using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuFunctions : MonoBehaviour
{
    public Button StartGameBtn;
    public Button ControlsBtn;
    public Button QuitBtn;

    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ControlMenu()
    {
        SceneManager.LoadScene("ControlsMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }



}
