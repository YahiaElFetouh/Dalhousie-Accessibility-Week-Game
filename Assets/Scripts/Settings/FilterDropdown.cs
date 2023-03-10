using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

//YouTube. (2020). Unity Ui Tutorial Dropdown C# Scripting. YouTube. 
//Retrieved March 1, 2023, from https://www.youtube.com/watch?v=URS9A4V_yLc. 

//Also thanks for the help from CSCIx691 TA: Anay Awasthi


public class FilterDropdown : MonoBehaviour
{
    
    void Start()
    {
        //get the value from drop down, it's like 0, 1, 2, 3
        var dropdown = transform.GetComponent<Dropdown>();
        
        //make change for dropdown by different choice, detail in function :void DropdownItemSelected(Dropdown d)
        DropdownItemSelected(dropdown);
        
        //apply the change 
        dropdown.onValueChanged.AddListener(delegate {DropdownItemSelected(dropdown);});
        
    }


    void DropdownItemSelected(Dropdown d){

        //the colorblind is apply on the main camera
        Camera myCamera=Camera.main;

        
        var x=myCamera.GetComponent<Wilberforce.Colorblind>();

        //the type in colorblind script is by number0, 1, 2, 3, 
        //so apply the numbers to dropdown after the dropdown choice changes
        x.Type=d.value;
        
    }

    
}