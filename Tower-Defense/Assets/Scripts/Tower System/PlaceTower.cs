using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceTower : MonoBehaviour
{

    public GameObject Prefab;
    public Btn2Script Btn2Script;
    public Btn1Script Btn1Script;
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
        Btn1Script.placementOps.Remove(this.gameObject);
        Btn2Script.placementOptions.Remove(this.gameObject);
        Destroy(this.gameObject);
        Btn2Script.hidePlacementLocations();
        

    }
}
