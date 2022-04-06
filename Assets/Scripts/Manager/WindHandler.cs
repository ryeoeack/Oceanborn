using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WindHandler : MonoBehaviour
{
    public float mapInitialWind;
    public float wind{ get; private set; }
    public TextMeshProUGUI windIndicator;
    public static WindHandler instance;

    private void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        //setWind(mapInitialWind);
    }

    public void setWind(float x)
    {
        wind = x;
        string direction = x > 0 ? "East" : "West";
        windIndicator.text = "Wind: " + x*10 + ", " + direction;
    }

}
