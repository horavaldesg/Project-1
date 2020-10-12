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
    public static bool showItem;
    
    // Start is called before the first frame update
    void Start()
    {
        //items = new string[5];
        //items[1] = "rock";
        //items[2] = "sphere";
        currentItem = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {

        //if (showItem)
        //{
            currentItem.text = items[index];
            index = 0;
        //}
        
        
        //Debug.Log(currentItem.text = items[index]);
        //Debug.Log("index: " + index);
        
    }
}
