using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveMotion : MonoBehaviour
{
    public float frequency = 3.0f;
    public float wave = 2.0f;
    public float startDir = 1;
    float timer;
    // Update is called once per frame
    private void Start()
    {
        timer = frequency;
        wave *= startDir;
    }
    void Update()
    {
        if (timer > 0)
        {
            this.transform.position += new Vector3(wave * Time.deltaTime, 0, 0);
            timer -= Time.deltaTime;
        }
        else
        {
            timer = frequency;
            wave = -wave;
        }


    }
}
