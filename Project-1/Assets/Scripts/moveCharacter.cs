using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCharacter : MonoBehaviour
{
    public CharacterController cc;
    public Transform checkPos;
    public LayerMask groundMask;
    public Transform camTransform;
    public float speed = 5f;
    public float verticalSpeed = 0;
    public float Gravity = -9.8f;
    public float jumpSpeed = 9;

    float speedBoost;
    public float multiplier;
    bool grounded;

    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speedBoost = multiplier;
        }
        else
        {
            speedBoost = 1;
        }
        //movement
        Vector3 movement = Vector3.zero;
        float xSpeed = Input.GetAxis("Vertical") * speed * speedBoost * Time.deltaTime;
        movement += transform.forward * xSpeed;
        float ySpeed = Input.GetAxis("Horizontal") * speed * speedBoost * Time.deltaTime;
        movement += transform.right * ySpeed;

        //Gravtity
        verticalSpeed += Gravity * Time.deltaTime;

        movement += transform.up * verticalSpeed * Time.deltaTime;

       //Grounded
        if (Physics.CheckSphere(checkPos.position,0.5f, groundMask) && verticalSpeed <= 0)
        {
            grounded = true;
            verticalSpeed = 0;
        }
        else
        {
            grounded = false;
        }

        //Jump
        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            verticalSpeed = jumpSpeed;
        }

        //Raycast
        //if (Input.GetMouseButtonDown(0))
        //{
            RaycastHit hit;


            if (Physics.Raycast(camTransform.position, camTransform.forward, out hit))
            {

                if (hit.collider.CompareTag("Item"))
                {
                hitText.index = hit.transform.gameObject.GetComponent<items>().itemNumber;
                //if (items.counter <= 0)
                //{
                //    items.counting = true;
                //}
                

                }
                /*
                 * Add loading for first time analysis
                 */
                
            }
            
        //}
        cc.Move(movement);

        
    }
    
}
