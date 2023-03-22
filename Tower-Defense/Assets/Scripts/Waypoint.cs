using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    public Transform GoalPoint;
    public Transform self;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger entered");
        collision.gameObject.GetComponent<WayPointSystemScript>().movement = new Vector2(GoalPoint.position.x - self.position.x, GoalPoint.position.y - self.position.y);
    }
}
