using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleSave : MonoBehaviour
{
    public new string name;
    public UnityEngine.UI.Toggle toggle;

    // Start is called before the first frame update
    void Start()
    {
        name = this.gameObject.name;
        toggle = this.gameObject.GetComponent<UnityEngine.UI.Toggle>();
        int savedValue = PlayerPrefs.GetInt(name);
        
        if (PlayerPrefs.HasKey(name))
        {
            toggle.isOn = savedValue == 0 ? false : true;
            Debug.Log($"{name} = {PlayerPrefs.GetInt(name)}");
        }
    }

    public void SaveToggle()
    {
        bool toggleState = toggle.isOn;
        PlayerPrefs.SetInt(name, toggleState ? 1 : 0);
        PlayerPrefs.Save();
        Debug.Log($"{name} has been set to {toggleState} in PlayerPrefs.");
    }
}
