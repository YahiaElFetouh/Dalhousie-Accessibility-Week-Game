using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicVolume : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;

    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        Debug.Log("Volume Set to: '" + volumeSlider.value * 100 + "'%");
        Save();
    }

    //Save the player's volume preference to Player Prefs.
    private void Save()
    {
        PlayerPrefs.SetFloat("AudioVolume", volumeSlider.value);
    }
}
