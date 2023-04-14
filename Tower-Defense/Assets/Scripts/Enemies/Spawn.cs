using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public float cooldown;
    public GameObject[] enemies;
    public Transform start;
    public Transform goal;
    public bool spawning;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(spawn());
    }

    IEnumerator spawn()
    {
        if (!spawning)
        {
            spawning = true;
            int i = Random.Range(0, enemies.Length - 1);
            var enemy = Instantiate(enemies[i], transform.position, transform.rotation);
            enemy.GetComponent<WayPointSystemScript>().startPoint = start;
            enemy.GetComponent<WayPointSystemScript>().goalPoint = goal;

            yield return new WaitForSeconds(cooldown);
            spawning = false;
        }

    }
}
