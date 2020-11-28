using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class areaLocation : MonoBehaviour
{
    public string location;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            locationText.text = location;
            
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        locationText.text = "";
    }
}
