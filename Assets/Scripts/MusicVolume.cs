using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicVolume : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;

    private void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        Save();
    }

    //Load the player's saved volume preference
    public void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("AudioVolume");
    }

    //Save the player's volume preference
    private void Save()
    {
        PlayerPrefs.SetFloat("AudioVolume", volumeSlider.value);
    }
}
