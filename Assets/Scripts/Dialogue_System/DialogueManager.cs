using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ink.Runtime;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class DialogueManager : MonoBehaviour
{
    private static DialogueManager instance;
    private GameManager gameManager;

    [Header("Dialogue UI")]
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private TextMeshProUGUI dialogueText;

    [SerializeField] private float typeWriterSpeed = 30f;


    [Header("Choices UI")]
    [SerializeField] private GameObject[] choices;
    private TextMeshProUGUI[] choicesText;

    [Header("Dialogue Navigation Info")]
    [SerializeField] public GameObject continueDialogueCue;
    private int levelOne_Guide = 0;

    private Story currentStory;
    public bool dialogueIsPlaying;
    public int lockTyping;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Found more than one Dialogue Manager in the Scene");
        }
        continueDialogueCue.SetActive(false);
        instance = this;
    }

    public static DialogueManager GetInstance()
    {
        return instance;
    }

    public void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);

        //get all of the choices text
        choicesText = new TextMeshProUGUI[choices.Length];

        int index = 0;
        foreach (GameObject choice in choices)
        {
            choicesText[index] = choice.GetComponentInChildren<TextMeshProUGUI>();
            index++;
        }


    }

    private void Update()
    {
        if (!dialogueIsPlaying)
        {
            return;
        }

        if (currentStory.currentChoices.Count == 0 && Input.GetKeyDown("space"))
        {
            ContinueStory();
        }

    }


    public void EnterDialogueMode(TextAsset inkJSON)
    {
        currentStory = new Story(inkJSON.text);

        dialogueIsPlaying = true;

        continueDialogueCue.SetActive(true);
        Debug.Log("level status [0?]: " + levelOne_Guide);
        ContinueStory();
    }

    private void ExitDialogueMode()
    {
        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);

        if(dialogueIsPlaying == false) {
            if (SceneManager.GetActiveScene().name == "Story1-ADHD") {
                SceneManager.LoadScene("Story2-Substance_Abuse");
            }
            else if (SceneManager.GetActiveScene().name == "Story2-Substance_Abuse") {
                SceneManager.LoadScene("Story3-BPD");
            }
            else if (SceneManager.GetActiveScene().name == "Story3-BPD") {
                SceneManager.LoadScene("Credits_Page_End");
            } else {
                SceneManager.LoadScene("MainMenu");
            }

        }
        dialogueText.text = "";
    }


    private void ContinueStory()
    {
        if (currentStory.canContinue)
        {
            if (levelOne_Guide == 0) {
                levelOne_Guide = 1;
                Debug.Log("level status [1?]: " + levelOne_Guide);
            } 
            else {
                continueDialogueCue.SetActive(false);
                Debug.Log("Controls UI closed");

                dialoguePanel.SetActive(true);

                if (lockTyping == 0 && gameManager)
                {
                    //lockTyping = 1;
                    // This applies the replacement above by using a typwriter function
                    string textToType = currentStory.Continue();
                    dialogueText.text = textToType;
                    // use the string textToType and start tying it to dialogueText (inside the box)
                    //StartCoroutine(TypeText(textToType, dialogueText));
                    
                    gameManager.incrementLines(); //Updated to next background image
                }

                // display choices, if any, for this dialogue line
                displayChoices();
            }
        }
        else
        {
            ExitDialogueMode();

        }
    }

    /**
     * Method to type text by each characher (str), it gets locked until it 
     * finishes to type in the dialog box(dialogueText) then unlocks for next
     * textToType
     * 
     */
    private IEnumerator TypeText(string textToType, TextMeshProUGUI dialogueText)
    {

        dialogueText.text = string.Empty;
        lockTyping = 1;

        //yield return new WaitForSeconds(1);

        float t = 0;
        int charIndex = 0;

        while (charIndex < textToType.Length)
        {


            t += Time.deltaTime * typeWriterSpeed;
            charIndex = Mathf.FloorToInt(t);
            charIndex = Mathf.Clamp(charIndex, 0, textToType.Length);

            dialogueText.text = textToType.Substring(0, charIndex);

            yield return null;

        }

   
        
        lockTyping = 0;

        dialogueText.text = textToType;
    }


    private void displayChoices()
    {
        List<Choice> currentChoices = currentStory.currentChoices;

        if (currentChoices.Count > choices.Length)
        {
            Debug.LogError("More choices were given than the UI can support");
        }


        int index = 0;

        // enable and init the choices up to the amount of choices for this line of dialogue
        foreach(Choice choice in currentChoices)
        {
            choices[index].gameObject.SetActive(true);
            choicesText[index].text = choice.text;
            index++;
        }
        // go through the remaining choices the UI supports and make sure they're hidden
        for (int i = index; i < choices.Length; i++)
        {
            choices[i].gameObject.SetActive(false);
        }


        StartCoroutine(SelectFirstChoice());
    }


    private IEnumerator SelectFirstChoice()
    {
        // Event System needs to be cleared first then wait at least for one frame 

        EventSystem.current.SetSelectedGameObject(null);
        yield return new WaitForEndOfFrame();
        EventSystem.current.SetSelectedGameObject(choices[0].gameObject);
    }

    public void MakeChoice(int choiceIndex)
    {
        currentStory.ChooseChoiceIndex(choiceIndex);
    }
}
