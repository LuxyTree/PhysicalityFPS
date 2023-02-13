using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    //public float life = 6;

    //void Awake()
    //{
    //    Destroy(gameObject, life);
    //}

    void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Detected Collision");
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            Debug.Log("Player Shot");
        }

        if (collision.gameObject.tag == "Untagged")
        {
            Destroy(gameObject);
        }
    }
}
