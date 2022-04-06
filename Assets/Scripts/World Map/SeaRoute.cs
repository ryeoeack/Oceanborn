using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeaRoute : MonoBehaviour
{
    public List<City> citiesConnected;
    [SerializeField] City cityA;
    [SerializeField] City cityB;
    private bool isEnabled;
    [SerializeField] RouteData routeData;

    public void EnableRoute()
    {
        isEnabled = true;
    }

    private void OnMouseDown()
    {
        if (isEnabled)
        {
            GameManager.instance.FetchRoute(routeData);
            GameManager.instance.SceneTransition(2);
        }
    }
}
