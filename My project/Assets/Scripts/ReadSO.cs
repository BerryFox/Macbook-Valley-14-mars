using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadSO : MonoBehaviour
{
    public Fruits so;
    public string name;
    public int cost;
    public int sell;


    void Start()
    {
        this.gameObject.tag = "Legume";
        //RECUPËRATION DES ELEMENT DU SCRIPTABLE OBJECT POUR EVITER DE LE MODIFIER (SCRIPTABLE OBJECT)
        this.GetComponent<SpriteRenderer>().sprite = so.artwork;
        name = so.name.ToString(); //ToString == convertir en string
        cost = so.Buy;
        sell = so.Sell;

    }
}
