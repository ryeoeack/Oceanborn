using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public City playerCurrentCity;
    public int currentCityID;
    public CityData[] cityDatas;
    private int gameState;
    public RouteData routeToInitialize { get; private set; }
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        } else { Destroy(gameObject); }
        DontDestroyOnLoad(instance);
    }

    private void Awake()
    {
    }

    void Update()
    {
     
    }

    public void SceneTransition(int SceneID)
    {
        SceneManager.LoadScene(SceneID);
        gameState = SceneID; 
    }

    public void FetchRoute(RouteData route)
    {
        routeToInitialize = route;
    }

}
