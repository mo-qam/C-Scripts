
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunShot : MonoBehaviour
{

    public GameObject MuzzleFlash; // Gameobject prefab to play 

    private void Start()
    {
        GetComponent<Animation>().Play("sway"); // On scene start script will search for idle (sway) animation on weapon gameobject that is attached to player
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && GlobalAmmo.LoadedAmmo >= 1) // Weapon will be fired, only if there is ammo loaded, referencing Global Ammo Script
        {
            AudioSource gunsound = GetComponent<AudioSource>(); //Audiosource weapon sound will play on GetButtonDown
            gunsound.Play(); // Referenced audio source name
            MuzzleFlash.SetActive(true);    // Muzzleflash prefab stated at the beginning of script 
            StartCoroutine(MuzzleOff());    // Muzzleflash couroutine will be started once button has been pressed
            GetComponent<Animation>().Play("GunShot"); // Referencing recoil weapon animation on button down
            GlobalAmmo.LoadedAmmo -= 1;     // Referencing GlobalAmmo Script, this will reduce ammo by 1 on weapon fired


        }
        else
        {
            GetComponent<Animation>().Play("sway"); // And if we are not firing the weapon the weapon animation will return to its idle animation (sway)
        }

        
    }

    IEnumerator MuzzleOff() // This couroutine ensured that our muzzleflash prefab cannot be repeadetly played if the player presses the Fire1 key
    {
        yield return new WaitForSeconds(0.1f); // The muzzleflash will have a cooldown of 0.1 seconds before being able to play again
        MuzzleFlash.SetActive(false);
    }
}

