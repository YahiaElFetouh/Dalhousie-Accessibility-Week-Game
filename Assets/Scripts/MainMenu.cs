using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour{   

   public CursorSize cursorSettings;
   public MusicVolume musicVolumeSettings;
   public SoundManager musicToggleSettings;


   // Start is called before the first frame update
   public void Start()
   {
      //Updating Player Prefs.
      cursorSettings.cursorSizeStatus();
      musicVolumeSettings.audioVolumeStatus();
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
