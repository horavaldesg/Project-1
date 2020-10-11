using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseLook : MonoBehaviour
{
    public float sens = 50;
    public Transform camTransform;
    float camRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //Rotation
        float mouseX = Input.GetAxis("Mouse X") * sens * Time.deltaTime;
        transform.Rotate(new Vector3(0, mouseX, 0));

        float mouseY = -Input.GetAxis("Mouse Y") * sens * Time.deltaTime;
        //camTransform.Rotate(new Vector3(mouseY, 0, 0));
        camRotation += mouseY;
        camRotation = Mathf.Clamp(camRotation, -90f, 90f);
        camTransform.localRotation = Quaternion.Euler(new Vector3(camRotation,0,0));

        //if (Input.GetMouseButtonDown(1))
        //{
        //    camTransform.transform.localPosition = new Vector3(camTransform.transform.localPosition.x, camTransform.transform.localPosition.y, 10f);
        //}
        //else if(Input.GetMouseButtonUp(1))
        //{
        //    camTransform.transform.localPosition = new Vector3(camTransform.transform.localPosition.x, camTransform.transform.localPosition.y, 0.5f);
        //}


    }
}
