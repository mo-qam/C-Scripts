using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class GamePause : MonoBehaviour
{
    public static bool GameIsPaused = false;  // Game is not paused on Scene awake

    public GameObject pauseMenuUI; // Add Pause Menu Canvas UI here

    public GameObject FPSController; // Referencing the Player Controller so that we can disable it when PauseMenu is Activated
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // If key 'Escape' is pressed
        {
            if (GameIsPaused)
            {
                Resume();       
            }
            else
            {
                Pause();
                
            }
        }
    }
    public void Resume()    // If game is resumed and not paused...
    {
        pauseMenuUI.SetActive(false);               // Pause Menu is not active..
        Time.timeScale = 1f;                        // Time is set to normal
        GameIsPaused = false;                       // GameIsPaused Static bool is set to false
        FPSController.GetComponent<FirstPersonController>().enabled = true; // Player controller is enabled
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);               // Pause Menu is active
        Time.timeScale = 0f;                       // Time is set to 0f which is paused
        GameIsPaused = true;                       // and Game is Paused
        FPSController.GetComponent<FirstPersonController>().enabled = false; // Player controller is disabled so no camera movement can be active

    }

    public void Menu() // This is a reference for our PauseMenu UI button that takes us back to the game MainMenu
    {
        SceneManager.LoadScene("MainMenu");     // SceneManager loads the MainMenu if Canvas button is pressed in the PauseMenu
        Time.timeScale = 1f;                    // Time is set back to normal so that when MainMenu is loaded time is not frozen
        GameIsPaused = false;                   // Game is not paused when returning to MainMenu
    }
}
