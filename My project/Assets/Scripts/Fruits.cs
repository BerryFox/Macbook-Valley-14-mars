using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum nameFruit
{
   orange, carrot, courgette, tomate, peach, radish, strawberry, apple , zucchini
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

   
    float waterReserve = 100;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
}
