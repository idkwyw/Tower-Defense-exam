using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int PlayerHealth;
    public int PlayerMoney;
    public TextMeshProUGUI HPText;
    public TextMeshProUGUI MoneyText;
    public GameObject loseText;
    public static GameManager Instance;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        UpdatePlayerHP();
        UpdatePlayerMoney();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerHealth<=0)
        {
            loseText.SetActive(true);
        }
    }
    public void UpdatePlayerHP()
    {
        HPText.text = "HP: " + PlayerHealth.ToString() + "%";

    }

    public void UpdatePlayerMoney() 
    {
        MoneyText.text = "Money: " + PlayerMoney.ToString();
    }
}
