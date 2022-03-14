using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventaire : MonoBehaviour
{
    public List<Fruits> ListFruits;
    public int nbCarott, nbTomate;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Legume")
        { 
            switch(collision.gameObject.GetComponent<ReadSO>().so.name)
            {
                case nameFruit.carrot:
                    Debug.Log("Carrot");
                    nbCarott = nbCarott + 1;
                    break;

                case nameFruit.tomate:
                    Debug.Log("tomate");
                    nbTomate = nbTomate + 1;
                    break;
            }


            ListFruits.Add(collision.gameObject.GetComponent<ReadSO>().so); // AJOUTER LE SO DANS LA LISTE 
            Destroy(collision.gameObject);
        }
    }
}
