using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] Toggle toggler;

    public void musicToggleStatus()
    {
        AudioListener.pause = toggler.isOn;
        Debug.Log("Muted? " + toggler.isOn);
        Save();
    }

    private void Save()
    {
        PlayerPrefs.SetInt("MuteAudio", toggler.isOn ? 1 : 0);
        //Debug.Log("Update of Muted? " + toggler.isOn + " | " + toggler.isOn);
        AudioListener.pause = toggler.isOn;
    }
}
