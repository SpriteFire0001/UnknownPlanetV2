using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VictoryCommands : MonoBehaviour
{
    public Button LeaveMenu;


    public void ReturnToMenu()
    {
        SceneManager.LoadScene("MainMenu");


    }


}
