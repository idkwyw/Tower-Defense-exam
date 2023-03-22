using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointSystemScript : MonoBehaviour
{
    public Vector2 movement;
    public Transform startPoint;
    public Transform goalPoint;
    public GameObject self;

    // Start is called before the first frame update
    void Start()
    {
        movement = new Vector2(startPoint.position.x - goalPoint.position.x, startPoint.position.y - goalPoint.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        self.transform.Translate(movement * Time.deltaTime);
    }
}
