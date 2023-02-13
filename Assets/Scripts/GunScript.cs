using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    //Weapon
    public Transform bulletSpawnPoint;
    public GameObject redBulletPrefab;
    public GameObject greenBulletPrefab;
    public GameObject blueBulletPrefab;
    public float bulletSpeed = 10;
    public float redTime = 3;
    public float greenTime = 3;
    public float blueTime = 3;
    //Cooldown
    bool redcooldown = false;

    bool greencooldown = false;

    bool bluecooldown = false;

    //UI
    public GameObject IndicatorLeft;
    public GameObject IndicatorDown;
    public GameObject IndicatorRight;

    void Update()
    {
        RedShot();
        redTime -= Time.deltaTime;
        if (redTime < 0)
        {
            redcooldown= false;
            redTime= 3;
            IndicatorLeft.SetActive(true);
        }

        GreenShot();
        greenTime -= Time.deltaTime;
        if (greenTime < 0)
        {
            greencooldown = false;
            greenTime = 3;
            IndicatorDown.SetActive(true);
        }

        BlueShot();
        blueTime -= Time.deltaTime;
        if (blueTime < 0)
        {
            bluecooldown = false;
            blueTime = 3;
            IndicatorRight.SetActive(true);
        }
    }
    void RedShot()
    {
        if (Input.GetKey(KeyCode.A) && (Input.GetButtonDown("Fire1") && redcooldown == false))
        {
            redcooldown = true;
            var bullet = Instantiate(redBulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
            IndicatorLeft.SetActive(false);
        }
    }
    void GreenShot()
    {
        if (Input.GetKey(KeyCode.S) && (Input.GetButtonDown("Fire1") && greencooldown == false))
        {
            greencooldown = true;
            var bullet = Instantiate(greenBulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
            IndicatorDown.SetActive(false);
        }
    }
    void BlueShot()
    {
        if (Input.GetKey(KeyCode.D) && (Input.GetButtonDown("Fire1") && bluecooldown == false))
        {
            bluecooldown = true;
            var bullet = Instantiate(blueBulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
            IndicatorRight.SetActive(false);
        }
    }

}
