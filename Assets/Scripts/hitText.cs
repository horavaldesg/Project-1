using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class hitText : MonoBehaviour
{
    TextMeshProUGUI currentItem;
    string item;
    public string[] items;
    public static int index;
    
    // Start is called before the first frame update
    void Start()
    {
        items = new string[5];
        
        currentItem = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
        currentItem.text = items[index];
        index = 0;  
    }
}
