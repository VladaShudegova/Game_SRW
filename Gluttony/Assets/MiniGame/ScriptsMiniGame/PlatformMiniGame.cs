using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMiniGame : MonoBehaviour
{
      
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.transform.tag != "Player"){
            Destroy(collision.gameObject);
        }
    
    } 
}
