using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBulletScript : MonoBehaviour
{
    public float life = 3;

    void Awake()
    {
        Destroy(gameObject, life);
    }

    void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Detected Collision");
        if (collision.gameObject.tag == "GreenEnemy")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            Debug.Log("Detected Collision");
        }
    }
}
