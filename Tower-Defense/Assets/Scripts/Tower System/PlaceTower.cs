using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceTower : MonoBehaviour
{

    public GameObject Prefab;
    public Btn2Script Btn2Script;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Instantiate(Prefab, transform.position, transform.rotation);
        Destroy(this.gameObject);
        Btn2Script.hidePlacementLocations();
    }
}
