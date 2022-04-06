using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurfaceMotion : MonoBehaviour
{
    public float frequency = 3.0f;
    public float wave = 2.0f;
    float timer;
    // Update is called once per frame
    private void Start()
    {
        timer = frequency;
    }
    void Update()
    {
        if(timer > 0)
        {
            this.transform.position += new Vector3(0, wave*Time.deltaTime, 0);
            timer -= Time.deltaTime;
        }
        else
        {
            timer = frequency;
            wave = -wave;
        }
        
        
    }
}
