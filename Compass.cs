using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Compass : MonoBehaviour
{
    public Transform playerTransform; //the transform of the player.
    Vector3 dir; //the direction of the player's transform.

    private void Update()
    {
        dir.z = playerTransform.eulerAngles.y; //The player's direction on the Z axis is equal the player's transform from the Eular Angles on the Y axis.
        transform.localEulerAngles = dir; //the storage of local euler angles in the player's direction in rotation.
    }
}
