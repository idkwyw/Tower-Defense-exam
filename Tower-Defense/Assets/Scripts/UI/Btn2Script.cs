using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Btn2Script : MonoBehaviour
{
    public List<GameObject> placementOptions;
    public GameObject tower;
    public int priceOfTower;
    public GameManager GameManager;

    private void Start()
    {
        GameManager = GameManager.Instance;
    }
    public void showPlacementLocations()
    {
        GameManager = GameManager.Instance;

        if (GameManager.PlayerMoney>=priceOfTower)
        {
            for (int i = 0; i < placementOptions.Count; i++)
            {
                placementOptions[i].SetActive(true);
                placementOptions[i].GetComponent<PlaceTower>().Prefab = tower;
            }
        }
    }

    public void hidePlacementLocations()
    {
        GameManager = GameManager.Instance;

        for (int i = 0; i < placementOptions.Count; i++)
        {
            placementOptions[i].SetActive(false);
        }
    }
}
