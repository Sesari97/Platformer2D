using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Controller : MonoBehaviour
{
    public GameObject panelOptions;
    public GameObject canvasGameStart;

    void Start()
    {
        Time.timeScale = 0;
    }

    public void gameStart()
    {
        canvasGameStart.SetActive(false);
        Time.timeScale = 1;
    }
    public void showOptionpanel()
    {
        Time.timeScale = 0;
        panelOptions.SetActive(true);
    }

    public void hideOptionsPanel()
    {
        Time.timeScale = 1;
        panelOptions.SetActive(false);
    }

    public void gotoStartScreen()
    {
        SceneManager.LoadScene("Level1");
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
