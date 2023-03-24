using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile1 : MonoBehaviour
{
    public Vector3 direction;
    public float speed;
    public GameManager gameManager;

    
    private void Start()
    {
        gameManager = GameManager.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * Time.deltaTime * speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy1"))
        {
            if (collision.gameObject.GetComponent<Enemy1>().Health >= 1)
            {
                collision.gameObject.GetComponent<Enemy1>().Health -= 30;
            }
            else
            {
                gameManager.PlayerMoney += 10;
                gameManager.UpdatePlayerMoney();
                Destroy(collision.gameObject);
            }
        }
        else if (collision.gameObject.CompareTag("Enemy2"))
        {
            if (collision.gameObject.GetComponent<Enemy2>().Health>=1)
            {
                collision.gameObject.GetComponent<Enemy2>().Health -= 30;
            }
            else
            {
                gameManager.PlayerMoney += 20;
                gameManager.UpdatePlayerMoney();
                Destroy(collision.gameObject);
            }
        }
        Destroy(this.gameObject);
    }
}
