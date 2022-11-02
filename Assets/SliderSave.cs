using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderSave : MonoBehaviour
{
    private new string name;
    priv UnityEngine.UI.Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        name = this.gameObject.name;
        slider = this.gameObject.GetComponent<UnityEngine.UI.Slider>();
        float savedValue = PlayerPrefs.GetInt(name);
        
        if (PlayerPrefs.HasKey(name))
        {
            slider.value = savedValue;
            Debug.Log($"{name} = {PlayerPrefs.GetFloat(name)}");
        }
    }

    public void SaveSlider()
    {
        float sliderValue = slider.value;
        PlayerPrefs.SetFloat(name, sliderValue);
        PlayerPrefs.Save();
        Debug.Log($"{name} has been set to {sliderValue} in PlayerPrefs.");
    }
}