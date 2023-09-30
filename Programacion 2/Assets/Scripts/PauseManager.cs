using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseManager : MonoBehaviour
{
    public Button pause;
    public Button resume;
    public Button menu;
    public AudioSource music;

    public void Start()
    {
        resume.gameObject.SetActive(false);
        menu.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
    public void Pause()
    {
        pause.gameObject.SetActive(false);
        resume.gameObject.SetActive(true);
        menu.gameObject.SetActive(true);
        Time.timeScale = 0;
        music.Pause();
    }
    public void Resume()
    {
        pause.gameObject.SetActive(true);
        resume.gameObject.SetActive(false);
        menu.gameObject.SetActive(false);
        Time.timeScale = 1;
        music.UnPause();    
    }
    public void Menu()
    {
        SceneManager.LoadScene("Start");
    }
}
