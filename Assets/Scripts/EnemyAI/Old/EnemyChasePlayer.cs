using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChasePlayer : MonoBehaviour
{

    public Transform target;
    public Transform myTransform;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
        transform.Translate(Vector3.forward*8*Time.deltaTime);
    }
}
