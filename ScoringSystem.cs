using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoringSystem : MonoBehaviour
{
    

    public Text SteelCount;
    public static int SteelValue;





    // Start is called before the first frame update
    void Start()
    {
        SteelValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        LevelComplete();
        SteelCount.GetComponent<Text>().text = "Steel: " + SteelValue;
        
        
    }

    void LevelComplete()
    {
        if (SteelValue >= 5000)
        {
            SceneManager.LoadScene("YouWin");
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            

        }
    }

    
}
