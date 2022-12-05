using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    public int costo;

    public int AumentoDeSol;

    public float timeBtwIncreases;
    private float nextIncreaseTime;

    private GameManager gm;

     private void Start()
    {
        gm = FindObjectOfType<GameManager>();
        if( gm.gold < costo){
            gm.gold = 0;
        }else{
        gm.gold -= costo;
        }
    }
    private void Update() {
        if (Time.time > nextIncreaseTime)
        {
            nextIncreaseTime = Time.time + timeBtwIncreases;
            gm.gold += AumentoDeSol;
        }
    }
}
