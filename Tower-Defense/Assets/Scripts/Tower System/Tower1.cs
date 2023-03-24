using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower1 : MonoBehaviour
{
    public float BulletSpeed;
    public float coolDown;
    List<GameObject> Target = new List<GameObject>();
    public GameObject Bullet;
    public bool attack;
    

    // Update is called once per frame
    void Update()
    {
        if (Target.Count > 0) 
        {
            StartCoroutine(shoot());
        }
    }

    IEnumerator shoot()
    {
        if (!attack)
        {
            attack = true;
            shoot();
            yield return new WaitForSeconds(coolDown);
            attack = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy1") || collision.CompareTag("Enemy2"))
        {
            Target.Add(collision.gameObject);
            shoot();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy1")|| collision.CompareTag("Enemy2"))
        {
            Target.Remove(collision.gameObject);
        }
    }

    public void shooting()
    {
        Vector3 direction = Target[0].transform.position - transform.position;
        var bullet = Instantiate(Bullet, transform.position, transform.rotation);
        bullet.GetComponent<Projectile1>().
    }
}
