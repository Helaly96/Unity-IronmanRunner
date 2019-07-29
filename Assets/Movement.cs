using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // we made a rigid body and added it to the script

    // to link the rigid body to this script , we select the script and then add
    // the rigid body to it

    public Rigidbody rb;
    public float sf;
    public Rigidbody bullet_template;
    public ParticleSystem Fire;
    Vector3 BulletPosition;
    Vector3 FirePosition;
    int offset;
   // bool test;
    Quaternion BulletRotation;
    Quaternion FireRotation;
    Vector3 test9;
    public Animator anim;
    bool onetime;
    void Start()
    {
        offset = 20;
        onetime = true;

        //Debug.Log("Testing if the component is added!");
    }
        
    void Update()
    {
        if (rb.position.y < -10)
        {
            FindObjectOfType<GameManager>().EndGame(); 
        }

        // to make it constant with the frame rate
        if(Input.GetKey("w"))
        {
            // rb.AddForce(0, 0, sf , ForceMode.VelocityChange);
            //check 
            rb.AddForce(0, 0, sf);
            //anim.SetBool("test", true);

        }

        //anim.SetBool("test", false);
        if (Input.GetKey("d"))
        {
            //rb.AddForce(sf, 0,0, ForceMode.VelocityChange);
            rb.AddForce(sf, 0, 0);
            //if (onetime == true)
            //{
               // test9.Set(0, 0, 5);
               // test9.Set(0, 0, 10);
                //test9.Set(0, 0, 15);
                //test9.Set(0, 0, 20);
                //onetime = false;
                //transform.Rotate(test9);

           // }
            

        }
         if(Input.GetKey("s"))
        {
            //rb.AddForce(0, 0, -sf , ForceMode.VelocityChange);
            rb.AddForce(0, 0, -sf);
            onetime = true;

        }
         if(Input.GetKey("a"))
        {
            //rb.AddForce(-sf, 0, 0, ForceMode.VelocityChange);
            rb.AddForce(-sf, 0, 0);

        }

         if (Input.GetKey("e"))
        {
            ParticleSystem Fire_update;
            FireRotation.Set(90, 0, 0 ,0);
            rb.AddForce(0, sf , 0);
            //FirePosition.Set(transform.position.x, transform.position.y - 2, transform.position.z);
            //Fire.transform.position = FirePosition;
            //Fire_update = Instantiate(Fire, FirePosition, FireRotation);






        }

         if (Input.GetKey("q"))
        {
           
                Rigidbody Bullet;
                BulletPosition.Set(transform.position.x, transform.position.y-1 , transform.position.z + 10);
                BulletRotation.Set(0,180,0,0) ;


                //Debug.Log(transform.position);
                //Debug.Log(BulletPosition);

                Bullet = Instantiate(bullet_template, BulletPosition, BulletRotation) as Rigidbody;
                Bullet.AddForce(0, 0, 3000);
              





        }



        // we then will add the friciton


    }
}
