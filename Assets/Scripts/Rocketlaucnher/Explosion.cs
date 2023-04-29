using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Explosion : MonoBehaviour
{
    public float explosionLife = 1;

    void Awake()
    {
        Destroy(gameObject, explosionLife);
    }

    void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Detected Collision");
        if (collision.gameObject.tag == "RedEnemy")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            Debug.Log("Detected Collision");
        }
    }
}
