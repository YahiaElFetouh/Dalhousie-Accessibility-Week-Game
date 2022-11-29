using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour{


   //Play the game from beginning to end
   public void PlayGame(){
   Debug.Log("PLAY!");
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }


   //Play the game from selection screen
   public void LoadADHDScenerio(){
    SceneManager.LoadScene("(1) ADHD Story");
   }
   public void LoadSubstanceAbuseScenerio(){
    SceneManager.LoadScene("(2) Substance Use Story");
   }
   public void LoadBipolarScenerio(){
    SceneManager.LoadScene("(3) Bi-polar Story");
   }



   //Exit Game
   public void QuitGame(){
    Debug.Log("QUIT");
    Application.Quit();
   }
}

