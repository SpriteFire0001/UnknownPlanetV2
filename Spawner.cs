using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour

{
    public Transform[] spawnpoints; int I;
    public GameObject enemy;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            foreach (Transform I in spawnpoints);
            Instantiate(enemy, spawnpoints[I].position, spawnpoints[I].rotation);



        }
    }


}
