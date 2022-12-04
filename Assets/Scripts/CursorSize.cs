using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorSize : MonoBehaviour
{
    public Texture2D smallCursor;
    public Texture2D bigCursor;
     
    void cursorReduce()
    {
        Cursor.SetCursor(smallCursor, Vector2.zero, CursorMode.ForceSoftware);
    }

    void cursorEnlarge()
    {
        Cursor.SetCursor(bigCursor, Vector2.zero, CursorMode.ForceSoftware);
    }
}
