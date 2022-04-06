using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CityManager : MonoBehaviour
{
    private GameManager GM;
    private string cityName;
    private string factionName;
    public CityData cityData;
    
    public TextMeshProUGUI cityNameText;
    public TextMeshProUGUI infoText;

    public GameObject infoWindow;
    public GameObject tradeWindow;
    public GameObject ShipbuilderWindow;
    public GameObject currentWindow;
    //public GoodsData[] availableGoods;
    void Start()
    {
        GM = GameManager.instance;
        currentWindow = infoWindow;
        cityData = GM.cityDatas[GM.playerCurrentCity.id];
        cityName = cityData.cityName;
        factionName = cityData.faction;
        infoSetup();
    }

    void infoSetup()
    {
        cityNameText.text = "City of " + cityName;
        infoText.text = cityName + " is a moderate city of " + factionName + ".\n";
    }

    public void LeavePort()
    {
        GameManager.instance.SceneTransition(0);
    }

    public void TradeScreen()
    {
        currentWindow.SetActive(false);
        tradeWindow.SetActive(true);
        currentWindow = tradeWindow;
    }
}
