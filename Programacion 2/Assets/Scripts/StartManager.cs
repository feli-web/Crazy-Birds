using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartManager : MonoBehaviour
{
    public Image controlimage;
    void Start()
    {
        controlimage.gameObject.SetActive(false);
    }

    
    void Update()
    {
        Application.targetFrameRate = 60;

    }
    public void Play()
    {
        SceneManager.LoadScene("Runner");
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void Controls()
    {
        controlimage.gameObject.SetActive(true);

    }
    public void Controls2()
    {
        controlimage.gameObject.SetActive(false);

    }
}
