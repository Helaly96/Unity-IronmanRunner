using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayeCollision : MonoBehaviour
{
    // Start is called before the first frame update


    // this is the class we created
    public Movement move;


   //when anything collides with a player
  void OnCollisionEnter (Collision colli)
    {
       if(colli.collider.tag == "Obs.")
        {
          

            move.enabled=false;

            FindObjectOfType<GameManager>().EndGame(); ;


        }
    }
}
