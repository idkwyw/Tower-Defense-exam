using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower2 : MonoBehaviour
{
    public float ProjectileSpeed;
    public float cooldown;
    // private float tempCooldown;
    List<GameObject> Targets = new List<GameObject>();
    public GameObject Bullet;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("shooting");
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator shooting()
    {
        while(Targets.Count>0) 
        {
            shoot();
            yield return new WaitForSeconds(cooldown);
        }
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
