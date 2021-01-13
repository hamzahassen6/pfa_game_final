using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_player : MonoBehaviour
{
   
    public GameObject player;
    // Start is called before the first frame update


    // Update is called once per frame

    private   void OnCollisionEnter(Collision collision)
        {
            if (collision.collider.tag == ("enemy2") || collision.collider.tag == ("enemy"))
            {
                Destroy(player);
                 player = null;
            }
        }
     
    
}
