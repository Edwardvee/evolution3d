using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
   
   public void Jugar(){
     SceneManager.LoadScene("Juego");
   }

   public void Salir(){
    Debug.Log("Lograste Salir :D");
    Application.Quit();
   }
}
