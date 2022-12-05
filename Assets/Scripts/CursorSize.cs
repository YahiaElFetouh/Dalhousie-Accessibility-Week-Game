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

    public void changeCursor()
    {
        if(cursorSlider.value == 0){
            cursorReduce();
        }
        else if (cursorSlider.value == 1){
            cursorReg();
        }
        else if (cursorSlider.value == 2){
            cursorEnlarge();
        }
        
    }

    void cursorReduce()
    {
        Cursor.SetCursor(smallCursor, Vector2.zero, CursorMode.ForceSoftware);
    }

    void cursorReg()
    {
        Cursor.SetCursor(regCursor, Vector2.zero, CursorMode.ForceSoftware);
    }

    void cursorEnlarge()
    {
        Cursor.SetCursor(bigCursor, Vector2.zero, CursorMode.ForceSoftware);
    }
}
