using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Explosion : MonoBehaviour
{
    public float radius;

    void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Detected Collision");
        if (collision.gameObject.tag == "RedEnemy")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            DrawGizmos();
            Debug.Log("Detected Collision");
        }
        if (collision.gameObject.tag == "Terrain")
        {
            //Destroy(collision.gameObject);
            Destroy(gameObject);
            DrawGizmos();
            Debug.Log("Detected Collision");
        }
    }

    private void DrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
