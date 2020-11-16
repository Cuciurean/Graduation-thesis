using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Clasa folosita pentru inchiderea aplicatie

public class SceneLoader : MonoBehaviour
{
    public void loadCamera()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    //Functia care inchide aplicatia
    public void ExitApp()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
