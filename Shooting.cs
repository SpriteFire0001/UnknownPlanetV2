using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform OrPoint; //The location where the bullet is firing from.
    public GameObject Bullet; //The bullet itself.
    public AudioSource LaserBlast;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //If the left mouse button is pressed.
        {
            LaserBlast.Play();
            Instantiate(Bullet, OrPoint.position, transform.rotation); //Summons the bullet from the origin point.
   
        }
    }
}
