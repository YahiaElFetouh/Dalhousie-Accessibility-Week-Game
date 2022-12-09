using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CharacterDisplayControllerSA : MonoBehaviour
{
    private GameObject textbox;
    public string currentCharacter;
    public string previousCharacter;
    private string[] textSplit;
    private TextMeshPro temp;
    private TMP_Text tempTMPText;
    private string tempString;

    public GameObject Character1;
    public GameObject Character2;
    public GameObject Character3;

    // Start is called before the first frame update
    void Start()
    {
        currentCharacter = "Nobody";
        previousCharacter = "Nobody";
        Character1.SetActive(false);
        Character2.SetActive(false);
        Character3.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        textbox = GameObject.Find("DialogueText");
        //print(textbox);
        if (textbox != null)
        {
            
            textSplit = textbox.GetComponent<TMP_Text>().text.Split(':');
            print(textSplit[0]);
            if (textSplit.Length > 0)
            {
                if (textSplit[0] == "VP" || textSplit[0] == "Allie")
                {
                    currentCharacter = textSplit[0];
                }
                else if (textSplit[0] != "" && textSplit[0] != "V" && textSplit[0] != "A" && textSplit[0] != "Al" && textSplit[0] != "All" && textSplit[0] != "Alli")
                {
                    currentCharacter = "Nobody";
                }
            }

            
            
            if (previousCharacter != currentCharacter)
            {
                if (currentCharacter == "Nobody")
                {
                    Character1.transform.localScale = new Vector3(5,5,0);
                    Character1.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 1f);
                    Character2.transform.localScale = new Vector3(3,3,0);
                    Character2.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.25f);
                    Character3.transform.localScale = new Vector3(3,3,0);
                    Character3.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.25f);
                }
                else if (currentCharacter == "VP")
                {
                    Character1.transform.localScale = new Vector3(3,3,0);
                    Character1.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.25f);
                    Character2.transform.localScale = new Vector3(5,5,0);
                    Character2.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 1f);
                    Character3.transform.localScale = new Vector3(3,3,0);
                    Character3.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.25f);
                }
                else if (currentCharacter == "Allie")
                {
                    Character1.transform.localScale = new Vector3(3,3,0);
                    Character1.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.25f);
                    Character2.transform.localScale = new Vector3(3,3,0);
                    Character2.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.25f);
                    Character3.transform.localScale = new Vector3(5,5,0);
                    Character3.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 1f);
                }
                
                previousCharacter = currentCharacter;
                Character1.SetActive(true);
                Character2.SetActive(true);
                Character3.SetActive(true);
            }
            else if (textbox.GetComponent<TMP_Text>().text == "I wake")
            {
                Character1.SetActive(true);
                Character2.SetActive(true);
                Character3.SetActive(true);
                Character1.transform.localScale = new Vector3(5,5,0);
                Character1.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 1f);
                Character2.transform.localScale = new Vector3(3,3,0);
                Character2.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.25f);
                Character3.transform.localScale = new Vector3(3,3,0);
                Character3.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.25f);
            }
        }

        
    }
}

