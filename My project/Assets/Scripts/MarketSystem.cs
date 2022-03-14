using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarketSystem : MonoBehaviour
{
    public string periode;
    public Inventaire inv;
    public int wallet;

    public float itime;
    public int valueTime;
    public int v;
    public List<string> season;
    public List<int> bugList; //0 = Carotte, 1 = tomate, 2 = orange, 3 = Zucchini, 4 = Peach, 5 = strawberry, 6 = apple
    private void Awake()
    {
        season.Add("Winter");
        season.Add("Spring");
        season.Add("Holiday");
        season.Add("Autumn");
    }
    void Start()
    {

        itime = valueTime;
        v = 0;
    }

    // Update is called once per frame
    void Update()
    {
        periode = season[v];

        itime = itime - Time.deltaTime;

        if(itime <= 0)
        { 
            if(v >= 3)
            {
                v = 0;
                itime = valueTime;
            }
            else
            {
                itime = valueTime;
                v = v + 1;
            }
            
        }
        switch(periode) //PRIX DES LEGUME SELON LA PERIODE 
        {
            case "Winter":
                bugList[0] = 180;
                break;
            case "Spring":
                bugList[0] = 110;
                break;
            case "Holiday":
                bugList[0] = 150;
                break;
            case "Autumn":
                bugList[0] = 30;
                break;
        }
        if(Input.GetKeyDown(KeyCode.A)) // VENTE DE TOMATE
        {
            if(inv.nbTomate > 0)
            {
                inv.nbTomate = inv.nbTomate - 1;
                wallet = wallet + bugList[1];
            }
            
        }
        if (Input.GetKeyDown(KeyCode.B)) //VENTE DE CARROT
        {
            if (inv.nbCarott > 0)
            {
                inv.nbCarott = inv.nbCarott - 1;
                wallet = wallet + bugList[0];
            }
        }
    }
}
