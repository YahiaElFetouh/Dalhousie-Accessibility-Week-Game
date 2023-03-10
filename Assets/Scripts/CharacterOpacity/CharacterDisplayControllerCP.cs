using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CharacterDisplayControllerCP : MonoBehaviour
{
    private GameObject textbox;
    public string currentCharacter;
    public string previousCharacter;
    private string[] textSplit;
    private TextMeshPro temp;
    private TMP_Text tempTMPText;
    private string tempString;
    private string emotion;
    
    public Sprite[] images;
    public GameObject Character1;
    public GameObject Character2;
    public GameObject Character3;
    public GameObject Character4;
    public GameObject Character5;
    public GameObject Character6;
    public GameObject Character7;
    public GameObject Character8;
    public GameObject Character9;


    // Start is called before the first frame update
    void Start()
    {
        Character1.SetActive(false);
        Character2.SetActive(false);
        Character3.SetActive(false);
        Character4.SetActive(false);
        Character5.SetActive(false);
        Character6.SetActive(false);
        Character7.SetActive(false);
        Character8.SetActive(false);
        Character9.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        textbox = GameObject.Find("DialogueText");
        //print(textbox);
        if (textbox != null)
        {
            
            textSplit = textbox.GetComponent<TMP_Text>().text.Split(':');
            if (textSplit.Length > 0)
            {
                if (textSplit[0] == "Gloriah" || textSplit[0] == "Glorias" || textSplit[0] == "Gloriaf" || textSplit[0] == "Gloriao" 
                || textSplit[0] == "Emilyh" || textSplit[0] == "Emilys" || textSplit[0] == "Marshac"|| textSplit[0] == "Marshaa" 
                || textSplit[0] == "Marshan" || textSplit[0] == "Glennc" || textSplit[0] == "Glennh" || textSplit[0] == "George" 
                || textSplit[0] == "Joseph" || textSplit[0] == "Julie" || textSplit[0] == "Sonya" 
                || textSplit[0] == "Henryc" || textSplit[0] == "Henryn")
                {
                    currentCharacter = textSplit[0];
                }
            }
            if (previousCharacter != currentCharacter)
            {

                if (currentCharacter == "Gloriah")
                {
                    Character1.GetComponent<SpriteRenderer>().sprite = images[0];
                    Character1.transform.localScale = new Vector3(0.4f,0.4f,0);
                    Character1.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 1f);
                    Character2.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character2.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character3.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character3.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character4.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character4.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character5.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character5.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character6.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character6.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character7.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character7.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character8.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character8.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character9.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character9.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                }
                if (currentCharacter == "Glorias")
                {
                    Character1.GetComponent<SpriteRenderer>().sprite = images[1];
                    Character1.transform.localScale = new Vector3(0.4f,0.4f,0);
                    Character1.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 1f);
                    Character2.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character2.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character3.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character3.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character4.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character4.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character5.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character5.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character6.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character6.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character7.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character7.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character8.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character8.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character9.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character9.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                }
                if (currentCharacter == "Gloriaf")
                {
                    Character1.GetComponent<SpriteRenderer>().sprite = images[2];
                    Character1.transform.localScale = new Vector3(0.4f,0.4f,0);
                    Character1.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 1f);
                    Character2.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character2.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character3.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character3.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character4.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character4.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character5.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character5.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character6.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character6.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character7.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character7.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character8.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character8.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character9.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character9.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                }
                if (currentCharacter == "Gloriao")
                {
                    Character1.GetComponent<SpriteRenderer>().sprite = images[3];
                    Character1.transform.localScale = new Vector3(0.4f,0.4f,0);
                    Character1.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 1f);
                    Character2.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character2.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character3.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character3.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character4.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character4.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character5.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character5.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character6.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character6.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character7.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character7.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character8.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character8.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character9.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character9.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                }
                if (currentCharacter == "Emilyh")
                {
                    Character2.GetComponent<SpriteRenderer>().sprite = images[4];
                    Character1.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character1.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character2.transform.localScale = new Vector3(0.4f,0.4f,0);
                    Character2.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 1f);
                    Character3.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character3.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character4.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character4.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character5.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character5.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character6.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character6.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character7.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character7.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character8.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character8.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character9.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character9.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                }
                if (currentCharacter == "Emilys")
                {
                    Character2.GetComponent<SpriteRenderer>().sprite = images[5];
                    Character1.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character1.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character2.transform.localScale = new Vector3(0.4f,0.4f,0);
                    Character2.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 1f);
                    Character3.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character3.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character4.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character4.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character5.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character5.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character6.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character6.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character7.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character7.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character8.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character8.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character9.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character9.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                }
                if (currentCharacter == "Marshac")
                {
                    Character3.GetComponent<SpriteRenderer>().sprite = images[6];
                    Character1.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character1.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character2.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character2.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character3.transform.localScale = new Vector3(0.4f,0.4f,0);
                    Character3.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 1f);
                    Character4.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character4.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character5.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character5.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character6.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character6.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character7.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character7.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character8.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character8.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character9.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character9.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                }
                if (currentCharacter == "Marshaa")
                {
                    Character3.GetComponent<SpriteRenderer>().sprite = images[7];
                    Character1.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character1.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character2.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character2.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character3.transform.localScale = new Vector3(0.4f,0.4f,0);
                    Character3.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 1f);
                    Character4.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character4.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character5.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character5.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character6.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character6.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character7.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character7.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character8.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character8.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character9.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character9.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                }
                if (currentCharacter == "Marshan")
                {
                    Character3.GetComponent<SpriteRenderer>().sprite = images[8];
                    Character1.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character1.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character2.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character2.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character3.transform.localScale = new Vector3(0.4f,0.4f,0);
                    Character3.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 1f);
                    Character4.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character4.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character5.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character5.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character6.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character6.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character7.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character7.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character8.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character8.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character9.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character9.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                }
                if (currentCharacter == "Glennc")
                {
                    Character4.GetComponent<SpriteRenderer>().sprite = images[9];
                    Character1.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character1.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character2.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character2.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character3.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character3.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character4.transform.localScale = new Vector3(0.4f,0.4f,0);
                    Character4.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 1f);
                    Character5.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character5.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character6.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character6.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character7.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character7.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character8.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character8.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character9.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character9.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                }
                if (currentCharacter == "Glennh")
                {
                    Character4.GetComponent<SpriteRenderer>().sprite = images[10];
                    Character1.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character1.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character2.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character2.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character3.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character3.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character4.transform.localScale = new Vector3(0.4f,0.4f,0);
                    Character4.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 1f);
                    Character5.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character5.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character6.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character6.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character7.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character7.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character8.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character8.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character9.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character9.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                }
                if (currentCharacter == "George")
                {
                    Character1.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character1.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character2.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character2.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character3.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character3.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character4.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character4.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character5.transform.localScale = new Vector3(0.4f,0.4f,0);
                    Character5.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 1f);
                    Character6.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character6.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character7.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character7.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character8.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character8.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character9.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character9.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                }
                if (currentCharacter == "Joseph")
                {
                    Character1.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character1.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character2.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character2.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character3.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character3.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character4.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character4.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character5.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character5.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character6.transform.localScale = new Vector3(0.4f,0.4f,0);
                    Character6.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 1f);
                    Character7.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character7.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character8.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character8.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character9.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character9.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                }
                if (currentCharacter == "Julie")
                {
                    Character1.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character1.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character2.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character2.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character3.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character3.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character4.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character4.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character5.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character5.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character6.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character6.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character7.transform.localScale = new Vector3(0.4f,0.4f,0);
                    Character7.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 1f);
                    Character8.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character8.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character9.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character9.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                }
                if (currentCharacter == "Sonya")
                {
                    Character1.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character1.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character2.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character2.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character3.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character3.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character4.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character4.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character5.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character5.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character6.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character6.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character7.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character7.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character8.transform.localScale = new Vector3(0.4f,0.4f,0);
                    Character8.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 1f);
                    Character9.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character9.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                }
                if (currentCharacter == "Henryc")
                {
                    Character4.GetComponent<SpriteRenderer>().sprite = images[11];
                    Character1.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character1.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character2.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character2.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character3.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character3.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character4.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character4.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character5.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character5.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character6.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character6.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character7.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character7.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character8.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character8.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character9.transform.localScale = new Vector3(0.4f,0.4f,0);
                    Character9.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 1f);
                }
                else if (currentCharacter == "Henryn")
                {
                    Character4.GetComponent<SpriteRenderer>().sprite = images[12];
                    Character1.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character1.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character2.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character2.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character3.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character3.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character4.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character4.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character5.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character5.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character6.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character6.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character7.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character7.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character8.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character8.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character9.transform.localScale = new Vector3(0.4f,0.4f,0);
                    Character9.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 1f);
                }
                previousCharacter = currentCharacter;
                Character1.SetActive(true);
                Character2.SetActive(true);
                Character3.SetActive(true);
                Character4.SetActive(true);
                Character5.SetActive(true);
                Character6.SetActive(true);
                Character7.SetActive(true);
                Character8.SetActive(true);
                Character9.SetActive(true);
            }
        }
    }
}