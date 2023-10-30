using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Iron : MonoBehaviour
{
    
    public Text SteelCount;
   
    // Start is called before the first frame update
    void Start()
    {
        
        SteelCount = GameObject.Find("SteelCounter").GetComponent<Text>(); //Used to fixed to UI assignment issues with the steel prefabs.
    }

    // Update is called once per frame


    

    public void OnCollisionEnter(Collision collision)
    {
        
        
        if (collision.gameObject.tag == "Player") //If the steel bar comes in contact.
        {


            Destroy(gameObject); //The Steel Bar gets destroyed by the player.
            ScoringSystem.SteelValue += 50; //The value of the steel pickup
           

            








            




        }
    }

    void Update()
    {

        
        DestroySelf();
    }

    //Time limit of the videogame pickup item.
    void DestroySelf()
    {
        Destroy(gameObject, 8f);
    }


}

