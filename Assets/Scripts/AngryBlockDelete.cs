using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngryBlockDelete : MonoBehaviour
{
   
    

    void FixedUpdate()
    {
          if (transform.position.y < -12)
        {
            Destroy(this.gameObject);
            
        }
    }
}
