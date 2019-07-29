using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HulkCrazy : MonoBehaviour
{
    public Rigidbody bullet_template;
    Vector3 BulletPosition;
    Quaternion BulletRotation;

    // Update is called once per frame
    void Update()
    {
        Rigidbody Bullet;
        BulletPosition.Set(transform.position.x, transform.position.y + 1, transform.position.z + 10);
        BulletRotation.Set(0, 180, 0, 0);


        //Debug.Log(transform.position);
        //Debug.Log(BulletPosition);

        Bullet = Instantiate(bullet_template, BulletPosition, BulletRotation) as Rigidbody;
        Bullet.AddForce(0, 0, 3000);
    }
}
