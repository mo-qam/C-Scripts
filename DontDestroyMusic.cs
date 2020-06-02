using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyMusic : MonoBehaviour
{                                                   // This script will keep desired music active even when the scene is changed
    void Awake() // On scene start
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Music");  // Script will find gameobject tagged with 'Music'
        if (objs.Length > 1)
            Destroy(this.gameObject);

        DontDestroyOnLoad(this.gameObject); // This ensured that the music is not destroyed if a new scene is loaded
    }
}
