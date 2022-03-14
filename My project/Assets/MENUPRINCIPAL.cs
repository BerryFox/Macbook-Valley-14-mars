using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MENUPRINCIPAL : MonoBehaviour{


    public void PlayGame()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void OptionsGame ()
    {
        Debug.Log("START OPTIONS");
        Application.Quit();
    }
}
