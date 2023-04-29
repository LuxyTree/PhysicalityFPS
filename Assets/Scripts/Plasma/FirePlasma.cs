using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePlasma : MonoBehaviour
{
    public float life = 3;
    public GameObject greenBulletPrefab;
    public GameObject chargedGreenBulletPrefab;
    public Transform bulletSpawnPoint;
    public float bulletSpeed = 10;

    //ChargedStuff
    [SerializeField] private GameObject chargedProjectile;
    [SerializeField] private float chargeSpeed;
    [SerializeField] private float chargeTime;
    private bool isCharging;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.S) && (Input.GetButton("Fire1") && chargeTime < 2))
        {
            isCharging= true;
            if(isCharging == true)
            {
                chargeTime += Time.deltaTime * chargeSpeed;
            }
        }
        if (Input.GetKey(KeyCode.S) && (Input.GetButtonDown("Fire1")))
        {
            var bullet = Instantiate(greenBulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
            chargeTime = 0;
        } else if (Input.GetButtonUp("Fire1") && chargeTime >=2) 
        {
            ReleaseCharge();
        }
    }
    void ReleaseCharge()
    {
        var bullet = Instantiate(chargedGreenBulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
        chargeTime = 0;
    }
}


