using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet2Script : MonoBehaviour
{
    public Vector3 Direction;
    public float Speed;


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Direction * Time.deltaTime * Speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy1"))
        {
            if (collision.gameObject.GetComponent<Enemy1>().Health>=1)
            {
                collision.gameObject.GetComponent<Enemy1>().Health -= 50;
            }
            else
            {
                Destroy(collision.gameObject);
            }
        }
        else if (collision.gameObject.CompareTag("Enemy2"))
        {
            if (collision.gameObject.GetComponent<Enemy2>().Health >= 1)
            {
                collision.gameObject.GetComponent<Enemy2>().Health -= 50;
            }
            else
            {
                Destroy(collision.gameObject);
            }
        }
        Destroy(this.gameObject);
    }
}
