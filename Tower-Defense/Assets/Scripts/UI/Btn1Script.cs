using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Btn1Script : MonoBehaviour
{
    public GameObject prefab;

    public void spawn()
    {
        Instantiate(prefab, new Vector3(0, 0, 0), transform.rotation);
    }


}
