using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower2 : MonoBehaviour
{
    public float ProjectileSpeed;
    List<GameObject> Targets = new List<GameObject>();
    public GameObject Bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy1") || collision.CompareTag("Enemy2"))
        {
            Targets.Add(collision.gameObject);
            shoot();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy1")|| collision.CompareTag("Enemy2"))
        {
            Targets.Remove(collision.gameObject);

        }
    }

    public void shoot()
    {
        Vector3 direction = Targets[0].transform.position - transform.position;
        var bullet = Instantiate(Bullet,transform.position,transform.rotation);
        bullet.GetComponent<Bullet2Script>().Direction = direction.normalized;
        bullet.GetComponent<Bullet2Script>().Speed = ProjectileSpeed;

    }
}
