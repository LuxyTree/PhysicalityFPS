using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    //Weapon
    public Transform bulletSpawnPoint;
    public GameObject redBulletPrefab;
    //public GameObject greenBulletPrefab;
    public GameObject blueBulletPrefab;
    public float bulletSpeed = 10;
    public float redTime = 5;
    //public float greenTime = 3;
    public float blueTime = 3;

    ////Chargeshot
    //[SerializeField] private GameObject chargedProjectile;
    //[SerializeField] private float chargeSpeed;
    //[SerializeField] private float chargetime;
    //private bool isCharging;

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

        //GreenShot();
        //greenTime -= Time.deltaTime;
        //if (greenTime < 0)
        //{
        //    greencooldown = false;
        //    greenTime = 3;
        //    IndicatorDown.SetActive(true);
        //}

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
            StartCoroutine(LaunchMultiple(5));
            IndicatorLeft.SetActive(false);
        }
    }

    private IEnumerator LaunchMultiple(int numLaunched)
    {
        var timesRepeated = 0;

        while (timesRepeated < numLaunched)
        {
            LaunchProjectile();
            timesRepeated++;
            yield return new WaitForSeconds(0.1f);
        }
    }

    void LaunchProjectile()
    {
        var bullet = Instantiate(redBulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
    }
    //void GreenShot()
    //{
    //    if (Input.GetKey(KeyCode.S) && chargetime <2 && (Input.GetKey("Fire1")))
    //    {
    //        IndicatorDown.SetActive(false);
    //        //greencooldown = true;
    //        isCharging = true;
    //        if(isCharging == true) 
    //        {
    //            chargetime += Time.deltaTime * chargeSpeed;
    //        }
    //    if (Input.GetButtonDown("Fire1"))
    //        {
    //            var bullet = Instantiate(greenBulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
    //            //chargetime = 0;
    //        } else if (Input.GetButtonUp("Fire1") && chargetime >= 2)
    //        {
    //            ReleaseCharge();
    //        }
    //    }
    //}

    //void ReleaseCharge()
    //{
    //    var bullet = Instantiate(greenBulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
    //    bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
    //    isCharging = false;
    //    chargetime = 0;
    //}
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
