using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    public int costo;

    public int Income;

    public float timeBtwIncreases;
    private float nextIncreaseTime;

    private GameManager gm;
    public BuildingSystemManuel bsm;


    private void Update() {
        if (Time.time > nextIncreaseTime)
        {
            nextIncreaseTime = Time.time + timeBtwIncreases;
            bsm.Deterioration += Income;
        }
    }
}
