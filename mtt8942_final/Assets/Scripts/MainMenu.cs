using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//script that allows the player to load the first person version,
//the third person version, or go back to the main menu
public class MainMenu : MonoBehaviour {


    public void PlayGamefirstperson()
    {
        SceneManager.LoadScene(4);
    }

    public void PlayGameThirdPerson()
    {
        SceneManager.LoadScene(1);
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
