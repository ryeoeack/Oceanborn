using System.Collections;
using UnityEngine;

namespace Assets.Scripts.World_Map
{
    public class WorldMapManager : MonoBehaviour
    {
        private City playerCurrentCity;
        private GameManager GM;
        // Use this for initialization
        void Start()
        {
            GM = GameManager.instance;
            playerCurrentCity = GM.playerCurrentCity;
            var startRenderer = playerCurrentCity.gameObject.GetComponent<Renderer>();
            startRenderer.material.color = new Color(255, 0, 0);
            playerCurrentCity.highlightRoutes();
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void BackToCity()
        {
            GM.SceneTransition(1);
        }
    }
}