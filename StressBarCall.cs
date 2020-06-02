using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StressBarCall : MonoBehaviour
{                                           // This script decreases 'HealthBar'
    
    void Update()               
    {
        if (Input.GetButtonDown("Fire1") && GlobalAmmo.LoadedAmmo >= 1) // If Button 'Fire1' has been pressed and GlobalAmmo is >=1 
        {
            StressBarScript.stress -= 5f;                               // Only then can the 'HealthBar' be decreased by 5f

        }
    }


}
