using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{

    public string mainMenuScene = "MainMenu";

    public void Retry()
    {
        SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex);
    }

    public void Menu()
    {
        SceneManager.LoadScene(mainMenuScene);
    }
}
