using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject redEnemy;
    [SerializeField]
    private GameObject greenEnemy;
    [SerializeField]
    private GameObject blueEnemy;

    [SerializeField]
    private float redInterval = 5f;
    [SerializeField]
    private float greenInterval = 3.5f;
    [SerializeField]
    private float blueInterval = 7f;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(redInterval, redEnemy));
        StartCoroutine(spawnEnemy(greenInterval, greenEnemy));
        StartCoroutine(spawnEnemy(blueInterval, blueEnemy));
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-5f,5), Random.Range(-6f, 6f), 0), Quaternion.identity);
        StartCoroutine(spawnEnemy(interval,enemy));    
    }
}
