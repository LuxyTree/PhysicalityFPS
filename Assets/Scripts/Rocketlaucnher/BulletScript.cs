using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float life = 3;
    public Transform BlueBullet;
    public float explosionLife = 1;
    public GameObject explosion;

    void Awake()
    {
        Destroy(gameObject, life);
    }

    void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Detected Collision");
        if (collision.gameObject.tag == "RedEnemy")
        {
            var bullet = Instantiate(explosion, BlueBullet.position, BlueBullet.rotation);
            Destroy(collision.gameObject);
            Destroy(gameObject);
            Debug.Log("Detected Collision");
        }
        if (collision.gameObject.tag == "Terrain")
        {
            //Destroy(collision.gameObject);
            Destroy(gameObject);
            var bullet = Instantiate(explosion, BlueBullet.position, BlueBullet.rotation);
            Debug.Log("Detected Collision");
        }
    }
}
