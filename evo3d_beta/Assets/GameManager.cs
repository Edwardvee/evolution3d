using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class GameManager : MonoBehaviour
{
    public int gold; 
    public Text goldDisplay;

    
    private Building buildingToPlace;

    public CustomCursor customCursor;
private void Update() 
      {
            goldDisplay.text = gold.ToString(); 
             
      }
      public void ComprarCosa(Building building){
            if(gold >= building.costo){
                  customCursor.gameObject.SetActive(true);
                  customCursor.GetComponent<SpriteRenderer>().sprite = building.GetComponent<SpriteRenderer>().sprite;
                  Cursor.visible = false;
                  gold -= building.costo;
                  buildingToPlace = building;
            }
      }
}  