using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class destroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {     
        
   Scene menuScene = SceneManager.GetSceneByName("MenuInicial");

        // Check if the menuScene object is valid
        if (menuScene.IsValid())
        {
         gameObject.SetActive(false);
        }
    SceneManager.sceneLoaded += OnSceneLoaded;
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "Juego")
        {
         gameObject.SetActive(true);
        }
         if (scene.name == "MenuInicial")
        {
         gameObject.SetActive(false);
        }
    }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
