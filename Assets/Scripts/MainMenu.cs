using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour{   

   public CursorSize cursorSettings;
   public MusicVolume musicVolumeSettings;
   public SoundManager musicToggleSettings;

   //Value for deafult settings setup
   public float DEFAULT_SETTINGS = 1;

   
   public void Start()
   {
      //Cursor Application - Cursor.cs
      if (!PlayerPrefs.HasKey("CursorSize")) 
      {
         PlayerPrefs.SetFloat("CursorSize", DEFAULT_SETTINGS);
         PlayerPrefs.Save();
      }
         
      //Music Volume Audio Application - MusicVolume.cs
      if(!PlayerPrefs.HasKey("AudioVolume"))
      {
         PlayerPrefs.SetFloat("AudioVolume", DEFAULT_SETTINGS);
         PlayerPrefs.Save();
      }

      //Music Volume Toggle Application - SoundManager.cs
      if(!PlayerPrefs.HasKey("muted")) 
      {
         PlayerPrefs.SetInt("muted", (int)DEFAULT_SETTINGS);
         AudioListener.pause = musicToggleSettings.muted;
      }

      cursorSettings.changeCursor();
    }


   /* Play the game from beginning to end */
   public void PlayGame(){
      Debug.Log("PLAY!");
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }


   /* Play the game from selection screen */
   public void LoadADHDScenerio()
   {
      Debug.Log("ADHD story loading");
      SceneManager.LoadScene("(1) ADHD Story");
   }

   public void LoadSubstanceAbuseScenerio()
   {
      Debug.Log("Substance Use story loading");
      SceneManager.LoadScene("(2) Substance Use Story");
   }

   public void LoadBipolarScenerio()
   {
      Debug.Log("Bi-polar story loading");
      SceneManager.LoadScene("(3) Bi-polar Story");
   }


   /* Quit Game Application */
   public void QuitGame()
   {
      Debug.Log("QUIT");
      Application.Quit();
   }
}
