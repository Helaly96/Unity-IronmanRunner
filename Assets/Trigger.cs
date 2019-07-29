using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameManager game_man;
    // Start is called before the first frame update
    void OnTriggerEnter(Trigger trig)
    {
        if(trig.tag == "Player")
        {
            game_man.CompleteLevel();

        }


    }
}
