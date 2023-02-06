using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject redBulletPrefab;
    public GameObject greenBulletPrefab;
    public GameObject blueBulletPrefab;
    public float bulletSpeed = 10;

    void Update()
    {
        if (Input.GetKey(KeyCode.A) && (Input.GetButtonDown("Fire1")))
        {
            var bullet = Instantiate(redBulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
        }

        if (Input.GetKey(KeyCode.S) && (Input.GetButtonDown("Fire1")))
        {
            var bullet = Instantiate(greenBulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
        }

        if (Input.GetKey(KeyCode.D) && (Input.GetButtonDown("Fire1")))
        {
            var bullet = Instantiate(blueBulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
        }
    }
}
