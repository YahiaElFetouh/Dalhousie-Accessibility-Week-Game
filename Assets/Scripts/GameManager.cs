using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Image original;
    public Sprite[] backgrounds;
    public int[] switchScenes;

    private int linesRead = 0;
    private int currentBG = 0;

    private void Start()
    {

    }

    private void Update()
    {

    }

    public void incrementLines()
    {
        linesRead++;
        if( switchScenes.Length >= currentBG && linesRead == switchScenes[currentBG])
        {
            nextBackground();
        }
    }
    public void nextBackground()
    {
        currentBG++;
        original.sprite = backgrounds[currentBG];
    }
}