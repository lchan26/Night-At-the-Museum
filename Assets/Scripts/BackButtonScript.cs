using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BackButtonScript : MonoBehaviour
{
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenuScreen");
    }

    public void GoToNextPage()
    {
        SceneManager.LoadScene("TutorialScreen 2");
    }

    public void GoToPrevPage()
    {
        SceneManager.LoadScene("TutorialScreen");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
