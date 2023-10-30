using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody PlayerRB; //Storage for the player's rigidbody.
    public Collider PlayerCollider; //Storage for the player's collider.
    public CharacterController PlayerController;
    public Text Healthcounter;
    

    public float speed = 12f;
    public float PlayerHealth = 200f;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        PlayerController.Move(move * speed * Time.deltaTime); 

        HealthDisplay();

    }

    public void PlayerTakesDamage(float PlayerAmount)
    {

        PlayerHealth -= PlayerAmount;
        
        if (PlayerHealth <= 0)
        {
            PlayerDies();
            PlayerHealth = 0;
        }

    }

    void PlayerDies()
    {
        SceneManager.LoadScene("GameOver");
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        
    }

    void HealthDisplay()
    {
        Healthcounter.text = PlayerHealth.ToString();
    }
    
}
