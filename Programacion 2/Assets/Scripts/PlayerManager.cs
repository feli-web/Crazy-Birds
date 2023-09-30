using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public Text lifetext;
    public Text timetext;
    public Text coinstext;

    private float time = 0;
    public int life;
    private int coins = 0;

    public SpriteRenderer sr;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        CheckMostTime();
        PlayerPrefs.SetFloat("TimePassed", time);

        timetext.text = "Time: "+ time.ToString("F2");
        coinstext.text = "Coins: "+ coins.ToString("D2");
        lifetext.text = "Life: "+ life;

        Application.targetFrameRate = 60;

    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            life--;
            Invoke("Red", 0.0f);
            Invoke("White", 0.1f);
            if (life <= 0)
            {
                SceneManager.LoadScene("GameOver");
            }
        }
        if (collision.gameObject.CompareTag("Coin"))
        {
            coins++;
            PlayerPrefs.SetInt("CoinsCollected", coins);
            CheckHighScore();
        }
    }
    public void Red()
    {
        sr.color = Color.red;
    }
    public void White()
    {
        sr.color = Color.white;
    }
    void CheckHighScore()
    {
        if (coins > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", coins);
        }
    }
    void CheckMostTime()
    {
        if (time > PlayerPrefs.GetFloat("MostTime", 0))
        {
            PlayerPrefs.SetFloat("MostTime", time);
        }
    }
}
