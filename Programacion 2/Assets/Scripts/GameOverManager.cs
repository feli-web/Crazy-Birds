using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public Text coinscollected;
    public Text highscorecoins;
    public Text lasttime;
    public Text besttime;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        coinscollected.text = $"Coins Collected:  {PlayerPrefs.GetInt("CoinsCollected", 0)}";
        highscorecoins.text = $"Most Coins Collected:  {PlayerPrefs.GetInt("HighScore", 0)}";
        lasttime.text = $"Last Time:  {PlayerPrefs.GetFloat("TimePassed", 0).ToString("F2")}";
        besttime.text = $"Best Time:  {PlayerPrefs.GetFloat("MostTime", 0).ToString("F2")}";

        Application.targetFrameRate = 60;
    }
    public void Menu()
    {
        SceneManager.LoadScene("Start");
    }
    public void TryAgain()
    {
        SceneManager.LoadScene("Runner");
    }
}
