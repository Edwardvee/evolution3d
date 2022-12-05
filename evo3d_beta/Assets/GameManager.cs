using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class GameManager : MonoBehaviour
{
    public int gold; 
    public Text goldDisplay;

    
    private Building buildingToPlace;

private void Update() 
      {
            goldDisplay.text = gold.ToString(); 
             
      }
      public void ComprarCosa(Building building){
            if(gold >= building.costo){
                  gold -= building.costo;
            }
      }
}  