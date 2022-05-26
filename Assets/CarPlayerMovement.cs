using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarPlayerMovement : MonoBehaviour
{


    [SerializeField] private float MoveSpeed = 5f;
    [SerializeField] private Rigidbody2D rb;

    Vector2 movement;

    [SerializeField] private float k=1f;
    void Update()
    {

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        //rb.MovePosition(rb.position + movement * MoveSpeed * Time.fixedDeltaTime);
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.MovePosition(rb.position + Vector2.left*k);
        }
        //else if (Input.GetKeyDown(KeyCode.D))
        //{
        //    rb.MovePosition(rb.position + Vector2.right*k);
        //}
        else if (Input.GetKey(KeyCode.W))
        {
            rb.MovePosition(rb.position + movement*MoveSpeed*Time.fixedDeltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rb.MovePosition(rb.position + movement * MoveSpeed * Time.fixedDeltaTime);
        }

        while(Input.GetKeyDown(KeyCode.D))
        {
            rb.MovePosition(rb.position + Vector2.right * k);
        }



    }
   
}
