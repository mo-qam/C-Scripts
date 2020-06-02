using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCasting : MonoBehaviour
{
                                                //This script creates raycasting from the player controller that can be referenced for firing weapons
    public static float DistanceFromTarget;     // Distance from Player to Target
    public float ToTarget;

    void Update()
    {

        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit)) // Raycast will be shot forward from player
        {
            ToTarget = hit.distance;
            DistanceFromTarget = ToTarget;
        }
    }
}