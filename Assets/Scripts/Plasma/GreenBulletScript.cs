using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenBulletScript : MonoBehaviour
{
    public float life = 3;
    public float bulletSpeed = 10;

    void Awake()
    {
        //var bullet = Instantiate(greenBulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        //bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
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
