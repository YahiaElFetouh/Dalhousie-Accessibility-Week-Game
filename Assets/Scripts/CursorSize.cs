using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CursorSize : MonoBehaviour
{
    public Texture2D smallCursor;
    public Texture2D bigCursor;
    public Texture2D regCursor;
    [SerializeField] Slider cursorSlider;

    // Sets Cursor Size based on Player Prefs. data:
    public void changeCursorSize()
    {
        if (PlayerPrefs.GetFloat("CursorSize") == 0) {
            cursorReduce();
        }
        else if (PlayerPrefs.GetFloat("CursorSize") == 1) {
            cursorReg();
        }
        else if (PlayerPrefs.GetFloat("CursorSize") == 0) {
            cursorEnlarge();
        }
        else {
            cursorReg();
        }
        Debug.Log("Cursor Size Set to: " + PlayerPrefs.GetFloat("CursorSize"));
    }

    // Changes Cursor Size based on slider input data:
    public void changeCursorSlider()
    {
        if(cursorSlider.value == 0){
            PlayerPrefs.SetFloat("CursorSize", 0);
            cursorReduce();
        }
        else if (cursorSlider.value == 1){
            PlayerPrefs.SetFloat("CursorSize", 1);
            cursorReg();
        }
        else if (cursorSlider.value == 2){
            PlayerPrefs.SetFloat("CursorSize", 2);
            cursorEnlarge();
        }
        else {
            cursorReg();
        }

    }


    /* Cursor Size Option Appliers */
    public void cursorReduce()
    {
        Cursor.SetCursor(smallCursor, Vector2.zero, CursorMode.ForceSoftware);
    }

    public void cursorReg()
    {
        Cursor.SetCursor(regCursor, Vector2.zero, CursorMode.ForceSoftware);
    }

    public void cursorEnlarge()
    {
        Cursor.SetCursor(bigCursor, Vector2.zero, CursorMode.ForceSoftware);
    }
}
