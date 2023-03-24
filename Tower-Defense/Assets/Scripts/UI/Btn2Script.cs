using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Btn2Script : MonoBehaviour
{
    public GameObject[] placementOptions;
    public GameObject tower;
    public void showPlacementLocations()
    {
        for (int i = 0; i < placementOptions.Length; i++)
        {
            placementOptions[i].SetActive(true);
            placementOptions[i].GetComponent<PlaceTower>().Prefab = tower;
        }
    }
}
