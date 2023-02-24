using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class FilterDropdown : MonoBehaviour
{

    
    
    
    void Start()
    {
        var dropdown = transform.GetComponent<Dropdown>();
        DropdownItemSelected(dropdown);
        dropdown.onValueChanged.AddListener(delegate {DropdownItemSelected(dropdown);});
        
    }

    


    void DropdownItemSelected(Dropdown d){
        Camera myCamera=Camera.main;
        var x=myCamera.GetComponent<Wilberforce.Colorblind>();
        x.Type=d.value;
        
    }


    
}