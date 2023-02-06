using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrosshairScript : MonoBehaviour
{
    public GameObject redCrosshair;
    public GameObject greenCrosshair;
    public GameObject blueCrosshair;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            redCrosshair.SetActive(true);
        }
        else
        {
            redCrosshair.SetActive(false);
        }

        if (Input.GetKey(KeyCode.S))
        {
            greenCrosshair.SetActive(true);
        }
        else
        {
            greenCrosshair.SetActive(false);
        }

        if (Input.GetKey(KeyCode.D))
        {
            blueCrosshair.SetActive(true);
        }
        else
        {
            blueCrosshair.SetActive(false);
        }

    }
}
