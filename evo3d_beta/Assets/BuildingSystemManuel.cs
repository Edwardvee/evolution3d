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
    private int currentBalance = 100;

    // The currently selected building type
    private GameObject selectedBuildingType;

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
                currentBuilding.transform.rotation = Quaternion.FromToRotation(Vector3.up, hit.normal);
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
                int cost = GetBuildingCost(selectedBuildingType);
                if (currentBalance >= cost)
                {
                    // If the user has enough virtual currency,
                    // subtract the cost of the building from their balance
                    currentBalance -= cost;

                    // Instantiate a new building at the placement location
                    currentBuilding = Instantiate(selectedBuildingType, placementLocation, Quaternion.identity);
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

    // This method is called when the user clicks the "Residential" button
    public void OnResidentialButtonClicked()
    {
        selectedBuildingType = residentialPrefab;
    }

    // This method is called when the user clicks the "Commercial" button
    public void OnCommercialButtonClicked()
    {
        selectedBuildingType = commercialPrefab;
    }

    // This method is called when the user clicks the "Industrial" button
    public void OnIndustrialButtonClicked()
    {
        selectedBuildingType = industrialPrefab;
    }

    // Returns the cost of the specified building prefab
    int GetBuildingCost(GameObject buildingPrefab)
    {
        // TODO: Implement this method to return the cost of the specified building prefab
        return 0;
    }
}
