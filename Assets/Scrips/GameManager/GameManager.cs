using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject Victorypanel;
    [SerializeField] private GameObject LosePanel;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        int gameResult = PlayerPrefs.GetInt("GameResult", -1);

        if (gameResult == 0)
        {
            ShowLose();
        }
        else if (gameResult == 1)
        {
            ShowVictory();
        }
    }
    public void ShowLose()
    {
       
        LosePanel.SetActive(true);
        Victorypanel.SetActive(false);
    }


    public void ShowVictory()
    {
       
        Victorypanel.SetActive(true);
        LosePanel.SetActive(false);
    }

}
