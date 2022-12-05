using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingSystemManuel : MonoBehaviour
{
     // Prefabs for the different types of buildings
    public GameObject residentialPrefab;
    public GameObject commercialPrefab;
    public GameObject industrialPrefab;

    // The building currently being placed by the user
    private GameObject currentBuilding;

    // The location where the building will be placed
    private Vector3 placementLocation;

    // The current balance of the player's virtual currency
    public int currentBalance;

    void Update()
    {
        // Get the current mouse position in screen space
        Vector3 mousePos = Input.mousePosition;

        // Use raycasting to find the ground plane where the building will be placed
        RaycastHit hit;
        if (Physics.Raycast(Camera.main.ScreenPointToRay(mousePos), out hit))
        {
            // Set the placement location to the point where the raycast hit the ground plane
            placementLocation = hit.point;

            // If the user is currently placing a building, update its position
            if (currentBuilding != null)
            {
                currentBuilding.transform.position = placementLocation;
            }
        }

        // If the user has pressed the left mouse button,
        // begin placing a new building of the selected type
        if (Input.GetMouseButtonDown(0))
        {
            if (currentBuilding == null)
            {
                // If the user is not currently placing a building,
                // check if they have enough virtual currency to buy one
                int cost = GetBuildingCost(residentialPrefab);
                if (currentBalance >= cost)
                {
                    // If the user has enough virtual currency,
                    // subtract the cost of the building from their balance
                    currentBalance -= cost;

                    // Instantiate a new building at the placement location
                    currentBuilding = Instantiate(residentialPrefab, placementLocation, Quaternion.identity);
                }
            }
            else
            {
                // If the user is already placing a building,
                // finish placing the current building
                currentBuilding = null;
            }
        }
    }

    // Returns the cost of the specified building prefab
    int GetBuildingCost(GameObject buildingPrefab)
    {
        // TODO: Implement this method to return the cost of the specified building prefab
        return 0;
    }
}
