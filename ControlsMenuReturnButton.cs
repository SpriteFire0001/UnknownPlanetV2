using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControlsMenuReturnButton : MonoBehaviour
{
    public Button Return;

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
