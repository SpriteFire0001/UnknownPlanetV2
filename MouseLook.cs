using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    public float mouseSensitivity = 5000f; //Storage for the sensitivty of the mouse.

    public Transform playerBody; //Stores the position of the player character.

    float xRotation = 0f; //the value of the rotation on the X-axis.

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; //Makes the cursor invisible.
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime; //Uses Unity's default input settings to enable mouse movement on the X-axis; camera movement function.
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime; //Uses Unity's default input settings to enable mouse movement on the Y-axis; camera movement function.

        xRotation -= mouseY; //descrease X-axis rotation by the Y-axis which creates rotation in the Y-axis
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); //limits the rotation value on the x-axis.

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX); //Mouse moves on the X-axis.

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (gameObject.tag == "mountain" && gameObject.tag == "ground")
        { 
            Destroy(gameObject);
        }
    }

}
