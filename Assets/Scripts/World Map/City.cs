using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class City : MonoBehaviour
{
    public List<SeaRoute> routesConnected;
    public CityData cityData;
    private string cityName;
    public int id;
    private void Start()
    {
        cityName = cityData.cityName;
        id = cityData.cityID;
        if(id == GameManager.instance.currentCityID)
        {
            GameManager.instance.playerCurrentCity = this;
        }
    }
    public void highlightRoutes()
    {
        for(int i = 0; i < routesConnected.Count; i++)
        {
            var tempRenderer = routesConnected[i].gameObject.GetComponent<Renderer>();
            tempRenderer.material.color = new Color(0, 0, 255);
            routesConnected[i].EnableRoute();
        }
    }
}
