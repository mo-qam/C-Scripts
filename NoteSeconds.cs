using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class NoteSeconds : MonoBehaviour
{       //Simple script to generate UI text on screen once player has entered the collider

    public GameObject uiquestion; // Add desired UI gameobject here from Scene Canvas


    private void Start() 
    {
        uiquestion.SetActive(false); // On Scene start the UI gameobject will be set false 

    }

     void OnTriggerEnter(Collider Player)
    {
        if (Player.gameObject.tag == "Player") // If BoxColliderTrigger encounters gameobject tagged with 'Player'
        {
            uiquestion.SetActive(true); // Then the UI object will be set true
            StartCoroutine("WaitForSec");  // This couroutine will ensure that the UI gameobject is destroyed after a x amount of seconds


        }
    }
    IEnumerator WaitForSec() // Couroutine to Destroy UI object after player has collided with trigger
    {
        yield return new WaitForSeconds(3); // Script will wait 3 seconds before destroying the UI object
        Destroy(uiquestion);
        Destroy(gameObject);
        Debug.Log("destroyed"); // Displayed in the console that the UI object has been 'Destroyed'
    }

    }

