using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PauseButton : MonoBehaviour
{
    // Boolean to keep track of whether the game is paused
    bool isPaused = false;

    // This method is called when the UI button is clicked
    public void OnPauseButtonClicked()
    {
        // Toggle the pause state
        isPaused = !isPaused;

        // If the game is paused, set the timescale to 0 to freeze everything
        if (isPaused)
        {
            Time.timeScale = 0;
        }
        // Otherwise, set the timescale back to 1 to resume normal gameplay
        else
        {
            Time.timeScale = 1;
        }
    }
}

