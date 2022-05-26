using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarPlayerMovement : MonoBehaviour
{


    
    [SerializeField] private Rigidbody2D rb;

    //Vector2 movement;

    [SerializeField] private float SpeedDown=1f;
    [SerializeField] private float SpeedLeftRight = 1f;
    [SerializeField] private float SpeedUp = 1f;
    
    void Update()
    {

        //movement.x = Input.GetAxisRaw("Horizontal");
        //movement.y = Input.GetAxisRaw("Vertical");


        if (Input.GetKey(KeyCode.A))
        {
            rb.MovePosition(rb.position + Vector2.left * SpeedLeftRight * Time.fixedDeltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.MovePosition(rb.position + Vector2.right * SpeedLeftRight * Time.fixedDeltaTime);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            rb.MovePosition(rb.position + Vector2.up * SpeedUp * Time.fixedDeltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rb.MovePosition(rb.position +Vector2.down * SpeedDown * Time.fixedDeltaTime);
        }





    }
   
}
