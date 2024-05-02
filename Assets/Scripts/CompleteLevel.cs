using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class CompleteLevel : MonoBehaviour
{
    public string menuSceneName = "MainMenu";
    public string nextLevel = "Level02";

    public void Continue()
    {
        SceneManager.LoadScene(nextLevel);
    }

    public void Menu ()
    {
        SceneManager.LoadScene(menuSceneName);
    }
}
