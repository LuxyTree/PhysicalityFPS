using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenBulletScript : MonoBehaviour
{
    public float life = 3;

    void Awake()
    {
        Destroy(gameObject, life);
    }

    void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Green Bullet " + gameObject.tag);
        if (collision.gameObject.tag == "BlueEnemy")
        {
            //Debug.Log("Box Color " + collision.gameObject.tag);
            Destroy(collision.gameObject);
            Destroy(gameObject);
            
        }
    }
}
