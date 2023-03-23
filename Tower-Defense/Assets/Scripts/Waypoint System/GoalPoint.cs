using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalPoint : MonoBehaviour
{
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        //gameManager = GameManager.Instance;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameManager.PlayerHealth -= 10;
        gameManager.UpdatePlayerHP();
        Destroy(collision.gameObject);
    }
}
