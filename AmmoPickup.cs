using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AmmoPickup : MonoBehaviour
{
    public AudioSource AmmoPickupSound; // Desired Ammo Pickup sound can be inputted her and dragged into the script via inspector
    void OnTriggerEnter(Collider other) // If ammo object collides with any collider...
    {
           AmmoPickupSound.Play(); // Then AmmoPickupSound will play
        if (GlobalAmmo.LoadedAmmo == 0) // Referencing GlobalAmmoScript, if loaded ammo = 0 then...
        {
            GlobalAmmo.LoadedAmmo += 10; // LoadedAmmo within the GlobalAmmo script will add 10 bullets
            this.gameObject.SetActive(false); // Once collider has been triggered and ammo has been added the ammo object will be setfalse
        }
        else
        {
            GlobalAmmo.CurrentAmmo += 10; // If Loaded Ammo Exceeds 10 then Current Ammo will be added 10 bullets
            this.gameObject.SetActive(false); // Once collider has been triggered and ammo has been added to CurrentAmmo object is setfalse
        }
                // The Ammo Object becomes set false so the player cannot continue to keep picking up ammo from one AmmoObject
    }
}