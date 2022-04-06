using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "City Data", menuName = "Scriptable Object/City Data", order = int.MaxValue)]
public class CityData : ScriptableObject
{

    public int cityID;
    public string cityName;
    public float wealth;
    public Image bgImage;
    public string faction;
}
