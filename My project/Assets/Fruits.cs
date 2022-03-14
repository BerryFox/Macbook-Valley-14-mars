using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum nameFruit
{
   orange, carrot, courgette, tomate 
}
[CreateAssetMenu(fileName = "New Fruit")]
public class Fruits : ScriptableObject
{
    public nameFruit name;
    Transform fruits;

    public Sprite artwork;
    public int Buy;
    public int Sell;
    public int GrowTimer;

    bool isGrowing = true;
    float waterReserve = 100;
    public float TimeToGrowth = 30;
    float Timer = 0;

    bool CanHarvest = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
}
