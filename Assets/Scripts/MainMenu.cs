using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour{   

   public CursorSize cursorSettings;
   public MusicVolume musicVolumeSettings;
   public SoundManager musicToggleSettings;

   //Deafult Settings Values:
   public float DEFAULT_SETTINGS_SLIDER = 1f;
   public int DEFAULT_SETTINGS_TOGGLE = 0;

   /* Here settings set by player already or by game for new playsers are made */
   public void Start()
   {
      //Cursor Application - Cursor.cs
      if(!PlayerPrefs.HasKey("CursorSize")) 
      {
         PlayerPrefs.SetFloat("CursorSize", DEFAULT_SETTINGS_SLIDER); //Regular 1
         PlayerPrefs.Save();
      }
         
      //Music Volume Audio Application - MusicVolume.cs
      if(!PlayerPrefs.HasKey("AudioVolume"))
      {
         PlayerPrefs.SetFloat("AudioVolume", DEFAULT_SETTINGS_SLIDER);
         PlayerPrefs.Save();
      }

      //Music Volume Toggle Application - SoundManager.cs
      if(!PlayerPrefs.HasKey("MuteAudio")) 
      {
         PlayerPrefs.SetInt("MuteAudio", (int) DEFAULT_SETTINGS_TOGGLE);
         PlayerPrefs.Save();
      }

      cursorSettings.changeCursorSize();
      musicVolumeSettings.ChangeVolume();
      musicToggleSettings.musicToggleStatus();
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
