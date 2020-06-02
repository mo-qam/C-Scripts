using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandGunDamage : MonoBehaviour
{
    public int DamageAmount = 5; // Damage amount given from player weapon
    public float TargetDistance; // This system uses raycasting which is a straight shot to targets from the player
    public float AllowedRange = 15.0f; // The range of the players bullet, note this system uses raycasting which does not contain bullet fall off


    void Update()
    {
        if (GlobalAmmo.LoadedAmmo >= 1) // Referencing GlobalAmmo script, checking if there are bullets loaded (>=1)
        {

            if (Input.GetButtonDown("Fire1")) // If LoadedAmmo is >=1 then the input 'Fire1' can be pressed providing the WeaponDamage
            {
                RaycastHit Shot;
                if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Shot)) // Ensured raycast shot from player positon
                {
                    TargetDistance = Shot.distance;
                    if (TargetDistance < AllowedRange) // Target will only recieve damage if Target is within AllowedRange public float (beginning of script)
                    {
                        Shot.transform.SendMessage("DeductPoints", DamageAmount, SendMessageOptions.DontRequireReceiver);
                    }           // On weapon fired, the script will deal damage to target 
                }
            }
        }
    }
}