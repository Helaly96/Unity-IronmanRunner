using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public    Transform    Player;
    public    Vector3      PlayerOffset;

    void Update()
    {
        transform.Rotate(0,Input.GetAxis("Mouse X"), 0);
        transform.position = Player.position + PlayerOffset ;
        
    }
}
