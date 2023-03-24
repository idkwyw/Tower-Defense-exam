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

    public static GameManager Instance;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        UpdatePlayerHP();
    }

    // Update is called once per frame
    void Update()
    {

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
