using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class StressBarScript : MonoBehaviour
{ 
    // Script simulates a healthbar slider that be used in various different senerious such as a "stress meter"
    private Image barImage; 
    float maxStress = 100f; // Image has a float value of 100f, meaning that at 100f, the UI slider will be full
    public static float stress; // Declaring public static float variable

    public void Awake() // Ensures that on scene start the UI slider would be present on screen
    {
        barImage = GetComponent<Image>(); // Referencing the private barImage at the beginning of the script which is just a simple low opacity red image
        stress = maxStress; // The value of the "health" slider is full on scene awake

    }

    void Update() // Variable that can be updated in everyframe
    {
        barImage.fillAmount = stress / maxStress; // The barImage is equal to full, then can be referenced through another script as desired
    
        if (stress == 0) // if the stress value is equal to 0 which is empty then this triggers a 'GameOver' scene through SceneManager
        {
            SceneManager.LoadScene("StressGameOver");
        }
    }



}



