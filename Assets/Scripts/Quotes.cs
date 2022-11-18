using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Quotes : MonoBehaviour
{
    /*
     Load scene
     */
    string[] sentences;
    byte count;
    TMP_Text TMP;
    string loadSceneName;
    float time;
    public byte waitTime;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Called start");
        time = 0;
        waitTime = 2;
        sentences = new string[]
        {
            "sentence 1", "sentences 2", "sentence 3", "sentence 4", "sentence 5"
        };
        TMP = this.gameObject.transform.GetChild(0).transform.GetChild(0).GetComponent<TMP_Text>();
        TMP.text = sentences[Random.Range(0, sentences.Length - 1)];
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time > waitTime)
        {
            time = 0;
            StartCoroutine(LoadYourAsyncScene());
            this.gameObject.SetActive(false);
        }
    }

    IEnumerator LoadYourAsyncScene()
    {
        // Set the current Scene to be able to unload it later
        Scene currentScene = SceneManager.GetActiveScene();

        // The Application loads the Scene in the background at the same time as the current Scene.
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(loadSceneName, LoadSceneMode.Additive);

        // Wait until the last operation fully loads to return anything
        while (!asyncLoad.isDone)
        {
            yield return null;
        }

        // Move the GameObject (you attach this in the Inspector) to the newly loaded Scene
        SceneManager.MoveGameObjectToScene(this.gameObject, SceneManager.GetSceneByName(loadSceneName));
        // Unload the previous Scene
        SceneManager.UnloadSceneAsync(currentScene);

    }

    public void setLoadSceneName(string name)
    {
        loadSceneName = name;
    }
}
