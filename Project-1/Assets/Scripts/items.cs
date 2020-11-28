using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class items : MonoBehaviour
{
    public int itemNumber;
    public static float counter;
    public static bool counting;
    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //    if (counting == true)
        //    {
        //        counter += Time.deltaTime;
        //    }
        //    if(counter > 10)
        //    {
        //        counter = 0;
        //        counting = false;
        //        hitText.showItem = true;
        //    }
        //    Debug.Log(counting);
        //    Debug.Log(counter);
    }
}
