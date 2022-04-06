using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldManager : MonoBehaviour
{
    public static FieldManager instance;

    private GameObject player;
    private GameObject waterSurface;

    public RouteData routeData;

    public CityEntrance eastsideCity;
    public CityEntrance westsideCity;

    public bool isInCityTrigger;

    void Start()
    {
        if(instance == null)
        {
            instance = this;
        } else { Destroy(gameObject); }
        player = GameObject.Find("Player");
        waterSurface = GameObject.FindObjectOfType<SurfaceMotion>().gameObject;
        routeData = GameManager.instance.routeToInitialize;
        initializeField(routeData.routeLength, routeData.initialWind);
    }

    private void LateUpdate()
    {
        //confine player
        if(player.transform.position.x < -10)
        {
            player.transform.position = new Vector3(-10, player.transform.position.y, 0);
        }
        if(player.transform.position.x > routeData.routeLength + 10)
        {
            player.transform.position = new Vector3(routeData.routeLength + 10, player.transform.position.y, 0);
        }
    }

    public void initializeField(float pathLength, float wind)
    {
        //initialize wind
        WindHandler.instance.setWind(routeData.initialWind);
        //initialize path
        waterSurface.transform.localScale = new Vector3(pathLength + 40f, 3, 1);
        waterSurface.transform.position = new Vector3(pathLength * 0.5f, -3, 0);
        //initialize player
        var curID = GameManager.instance.currentCityID;
        player.transform.position = curID == routeData.westsideCityID ? new Vector3(2, -1, 0) : new Vector3(pathLength-2, -1, 0);
        if(curID == routeData.eastsideCityID)
        {
            var spriteRenderer = player.GetComponent<SpriteRenderer>();
            spriteRenderer.flipX = true;
        }
        //initialize city entrances
        westsideCity.transform.position = new Vector3(0, -1, 0);
        westsideCity.id = routeData.westsideCityID;
        eastsideCity.transform.position = new Vector3(pathLength, -1, 0);
        eastsideCity.id = routeData.eastsideCityID;

    }
}
