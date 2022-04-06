using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityEntrance : MonoBehaviour
{
    public int id;
    void Start()
    {
        
    }

    private void OnMouseDown()
    {
        if (FieldManager.instance.isInCityTrigger)
        {
            //Change current city and transition to wolrd map
            GameManager.instance.currentCityID = id;
            GameManager.instance.SceneTransition(0);
        }

    }
}
