using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class DartAudio : MonoBehaviour
{
    public AudioClip dart;    // Add your Audio Clip Here;
                             // This Will Configure the  AudioSource Component; 
                             
    void Start() // On scene Start
    {
        GetComponent<AudioSource>().playOnAwake = false; // Audiosource wont be played on scene start
        GetComponent<AudioSource>().clip = dart; //Audiosource added at beginning of script will be false
    }

    void OnTriggerEnter(Collider Player)  //Plays Sound Whenever collision is detected with the object tagged with 'Player' within inspector
    {
        {
            if (Player.gameObject.tag == "Player")
                GetComponent<AudioSource>().Play(); // AudioSource will only play when the player has collided with the box trigger that contains this script
        }
        
    }
   
    
}