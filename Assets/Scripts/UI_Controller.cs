using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class UI_Controller : MonoBehaviour
{
    public GameObject panelOptions;
    public GameObject canvasGameStart;
    public AudioSource sound;

    void Start()
    {
        Time.timeScale = 0;
    }

    public void gameStart()
    {
        canvasGameStart.SetActive(false);
        Time.timeScale = 1;
        sound.Play();
    }
    public void showOptionpanel()
    {
        Time.timeScale = 0;
        panelOptions.SetActive(true);
        sound.Play();
    }

    public void hideOptionsPanel()
    {
        Time.timeScale = 1;
        panelOptions.SetActive(false);
        sound.Play();
    }

    public void gotoStartScreen()
    {
        SceneManager.LoadScene("Level1");
    }

    public void quitGame()
    {
        Application.Quit();
        sound.Play();
    }
}
