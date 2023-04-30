using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShootPlayer : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public Transform target;
    public Transform myTransform;
    public float bulletSpeed = 10;

    public GameObject EnemyBulletPrefab;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);

        if (Input.GetKeyDown(KeyCode.A))
        {
            var bullet = Instantiate(EnemyBulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
        }
    }
}
