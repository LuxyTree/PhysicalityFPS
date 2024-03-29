using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class RadialIndicatorScript : MonoBehaviour
{
    [SerializeField] private float indicatorTimer = 1.0f;
    [SerializeField] private float maxIndicatorTimer = 1.0f;

    [SerializeField] private Image radialIndicatorUI = null;

    //[SerializeField] private KeyCode selectKey = KeyCode.Mouse0;

    [SerializeField] private UnityEvent myEvent = null;

    private bool shouldUpdate = false;

    private void Update()
    {
        
        if ((Input.GetButtonUp("Fire1")))
        {
            shouldUpdate = false;
            indicatorTimer= Time.deltaTime;
            radialIndicatorUI.enabled = true;
            radialIndicatorUI.fillAmount = indicatorTimer;

            if(indicatorTimer <= 0)
            {
                indicatorTimer = maxIndicatorTimer;
                radialIndicatorUI.fillAmount = maxIndicatorTimer;
                //radialIndicatorUI.enabled = false;
                myEvent.Invoke();
            }
        }
        else
        {
            if(shouldUpdate)
            {
                indicatorTimer += Time.deltaTime;
                radialIndicatorUI.fillAmount = indicatorTimer;

                if (indicatorTimer >= maxIndicatorTimer)
                {
                    indicatorTimer = maxIndicatorTimer;
                    radialIndicatorUI.fillAmount = maxIndicatorTimer;
                    //radialIndicatorUI.enabled = false;
                    shouldUpdate = false;
                }
            }
        }
        if ((Input.GetKey(KeyCode.S)) && (Input.GetButton("Fire1")))
        {
            shouldUpdate = true;
        }
    }
}
