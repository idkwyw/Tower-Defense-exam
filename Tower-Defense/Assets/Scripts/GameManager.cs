using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int PlayerHealth;
    public TextMeshProUGUI HPText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HPText.text = "HP: " + PlayerHealth.ToString() + "%";
    }
}
