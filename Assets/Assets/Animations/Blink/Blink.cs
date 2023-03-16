using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Blink : MonoBehaviour
{
    private GameObject topLid;
    private GameObject bottomLid;
    private GameObject crashSound;

    private string moment1;
    private string moment2;
    private bool played1;
    private bool played2;

    private int linesRead = 0;

    private GameObject textbox;
    private string[] textSplit1;
    private string[] textSplit2;

    private TextMeshPro temp;
    private TMP_Text tempTMPText;

    

    // Start is called before the first frame update
    void Start()
    {
        topLid = GameObject.Find("Eyelid_Top");
        bottomLid = GameObject.Find("Eyelid_Bottom");
        crashSound = GameObject.Find("Crash");
        //Car crash soundeffectsfactory. MediaFire. (2021, September 15). Retrieved March 10, 2023, from https://www.mediafire.com/file/cd9k5trccmyt9e0/ 
        
        played1 = false;
        played2 = false;
    }

    // Update is called once per frame
    void Update()
    {
        textbox = GameObject.Find("DialogueText");

        if (textbox != null)
        {
            textSplit1 = textbox.GetComponent<TMP_Text>().text.Split('h');
            textSplit2 = textbox.GetComponent<TMP_Text>().text.Split('t');

            if (textSplit1.Length > 0)
            {
                if (textSplit1[0] == "Gloria(H): I mig"){
                    moment1 = textSplit1[0];
                }

                // Playing the blink animation and crash sound when Gloria crashes
                if(moment1 == "Gloria(H): I mig" && !played1) 
                {
                    topLid.GetComponent<Animation>().Play("BlinkTop");
                    bottomLid.GetComponent<Animation>().Play("BlinkBottom");
                    crashSound.GetComponent<AudioSource>().Play(); 
                    played1 = true;
                }
            }

            if (textSplit2.Length > 0)
            {
                if (textSplit2[0] == "Gloria(S): Hi Doc"){
                    moment2 = textSplit2[0];
                }

                // Playing opening animation once Gloria makes it to the doctor's office
                if(moment2 == "Gloria(S): Hi Doc" && !played2) 
                {
                    topLid.GetComponent<Animation>().Play("OpenTop");
                    bottomLid.GetComponent<Animation>().Play("OpenBottom");
                    played2 = true;
                }
            }
        }
    }
}

