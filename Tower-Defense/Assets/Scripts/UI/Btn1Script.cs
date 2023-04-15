using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Btn1Script : MonoBehaviour
{
    public List<GameObject> placementOps;
    public GameObject tower;
    public int towerPrice;
    public GameManager GameManager;
    public bool isFirstTimeBuying = true;

    private void Start()
    {
        GameManager = GameManager.Instance;
    }
    public void showPlacementOps()
    {
        GameManager = GameManager.Instance;

        if (GameManager.PlayerMoney >= towerPrice || isFirstTimeBuying)
        {
            isFirstTimeBuying = false;
            for (int i = 0; i < placementOps.Count; i++)
            {
                placementOps[i].SetActive(true);
                placementOps[i].GetComponent<PlaceTower>().Prefab = tower;
            }
        }
    }


}
