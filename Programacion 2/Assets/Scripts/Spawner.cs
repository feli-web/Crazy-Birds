using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] spawnobject;
    public float initialTime;
    public float repeatTime;
    private float time = 0;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", initialTime, repeatTime);
        Invoke("Increase", 50f);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
       
    }
    public void Spawn()
    {
        int f = Random.Range(0, spawnobject.Length);
        Instantiate(spawnobject[f], this.transform.position, this.transform.rotation);
    }
    public void Increase()
    {
        repeatTime *= 0.75f;
    }
}
