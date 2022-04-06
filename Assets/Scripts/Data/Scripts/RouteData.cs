using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Route Data", menuName = "Scriptable Object/Route Data", order = int.MaxValue)]

public class RouteData : ScriptableObject
{
    public float routeLength;
    public GameObject[] appearingEnemies;
    public float randomEvenetFrequency;
    public float initialWind;
    public int westsideCityID;
    public int eastsideCityID;
}
