using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DayNight : MonoBehaviour
{
    public SpriteRenderer sky;
    public Image saturation;


    void Start()
    {

        Day();

    }

    // Update is called once per frame
    void Update()
    {
      
    }
    public void Night()
    {
        sky.enabled = false;
        saturation.enabled = true;
        Invoke("Day", 50f);

    }
    public void Day()
    {
        sky.enabled=true;
        saturation.enabled = false;
        Invoke("Night", 50f);
    }
}
