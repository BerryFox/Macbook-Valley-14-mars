using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Harvester : MonoBehaviour
{
    bool CanHarvest = false;
    public GameObject press_E;
    public GameObject FruitsPanel;

    public PlayerMovement PM;
    // Start is called before the first frame update
    void Start()
    {
        press_E.SetActive(false);
    }

    private void Update()
    {
        if (CanHarvest && (Input.GetButtonDown("E")))
        {
            FruitsPanel.SetActive(true); // Open the harvest tool
            PM.SpeedMovement = 0; //If player enters in tool, reduce speed to 0.
        }
    }
    // Update is called once per frame 
    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.gameObject.tag == "Player_")
        {
            CanHarvest = true;
            press_E.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        press_E.SetActive(false);
        CanHarvest = false;


    }
}
