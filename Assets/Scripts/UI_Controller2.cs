using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class UI_Controller2 : MonoBehaviour
{
    public GameObject panelOptions;

    public AudioSource sound;


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
        sound.Play();
    }

    public void quitGame()
    {
        Application.Quit();
        sound.Play();
    }
}
