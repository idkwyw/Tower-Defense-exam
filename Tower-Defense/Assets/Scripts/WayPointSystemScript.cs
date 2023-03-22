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
        movement = new Vector2(goalPoint.position.x - startPoint.position.x, goalPoint.position.y - startPoint.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        if (self.transform.position.x>=goalPoint.position.x)
        {
            //movement = new Vector2(0, -1);

        }
        self.transform.Translate(movement * Time.deltaTime);
    }

}
