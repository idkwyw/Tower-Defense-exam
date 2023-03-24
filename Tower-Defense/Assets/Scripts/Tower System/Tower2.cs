using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower2 : MonoBehaviour
{
    public float ProjectileSpeed;
    public float cooldown;
    public List<GameObject> Targets = new List<GameObject>();
    public GameObject Bullet;
    public bool Attacking;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Targets.Count > 0)
        {
        StartCoroutine(shooting());

        }
    }

    IEnumerator shooting()
    {
     if(!Attacking) 
        {
            Attacking = true;
            shoot();
            yield return new WaitForSeconds(cooldown);
            Attacking = false;
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
        for (int i = 0; i < Targets.Count; i++)
        {
            Vector3 direction = Targets[i].transform.position - transform.position;
            var bullet = Instantiate(Bullet, transform.position, transform.rotation);
            bullet.GetComponent<Bullet2Script>().Direction = direction.normalized;
            bullet.GetComponent<Bullet2Script>().Speed = ProjectileSpeed;
        }

    }
}
