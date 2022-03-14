using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventaire : MonoBehaviour
{
    public List<Fruits> ListFruits;
    public int nbCarott, nbTomate, nbZucchini, nbRadish, nbStrawberry, nbApple, nbPeach ;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Legume") //if player enter in collision with object ''legume''
        { 
            switch(collision.gameObject.GetComponent<ReadSO>().so.name) //he recovers the int of each legumes
            {
                case nameFruit.carrot:
                    Debug.Log("Carrot");
                    nbCarott = nbCarott + 1;
                    break;

                case nameFruit.tomate:
                    Debug.Log("tomate");
                    nbTomate = nbTomate + 1;
                    break;

                case nameFruit.zucchini:
                    Debug.Log("Zucchini");
                    nbZucchini = nbZucchini + 1;
                    break;

                case nameFruit.radish:
                    Debug.Log("radish");
                    nbCarott = nbCarott + 1;
                    break;

                case nameFruit.strawberry:
                    Debug.Log("strawb");
                    nbStrawberry = nbStrawberry + 1;
                    break;

                case nameFruit.apple:
                    Debug.Log("apple");
                    nbApple = nbApple + 1;
                    break;

                case nameFruit.peach:
                    Debug.Log("peach");
                    nbPeach = nbPeach + 1;
                    break;


            }


            ListFruits.Add(collision.gameObject.GetComponent<ReadSO>().so); // Add the Scriptable object into the player's list
            Destroy(collision.gameObject);
        }
    }
}
