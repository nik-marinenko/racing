using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersCarDelete : MonoBehaviour
{
   
    void FixedUpdate()
    {
          if (transform.position.y < -20)
        {
            Destroy(this.gameObject);
            
        }
    }
}
