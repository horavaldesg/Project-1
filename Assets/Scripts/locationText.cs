using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class locationText : MonoBehaviour
{
    TextMeshProUGUI areaText;
    public static string text;
    // Start is called before the first frame update
    void Start()
    {
        areaText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        areaText.text = text;
        //text = " ";
    }
}
