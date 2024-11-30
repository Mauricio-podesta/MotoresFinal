using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ScenePlay1()
    {
        SceneManager.LoadScene("escena 1");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
