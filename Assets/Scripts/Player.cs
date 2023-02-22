using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int maxHealth = 10;
    public int currentHealth;

    public PlayerHealth healthbar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.I))
        {
            SceneManager.LoadScene("Tutorial Level");
        }

        if (Input.GetKey(KeyCode.O))
        {
            SceneManager.LoadScene("MEDLevel");
        }

        if (Input.GetKey(KeyCode.P))
        {
            SceneManager.LoadScene("HARDLevel");
        }

        if (currentHealth <= 0)
        {
            SceneManager.LoadScene("Tutorial Level");
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Detected Collision");
        if (collision.gameObject.tag == "RedEnemy")
        {
            TakeDamage(1);
            Debug.Log("Player Hit");
        }

        if (collision.gameObject.tag == "BlueEnemy")
        {
            TakeDamage(1);
            Debug.Log("Player Hit");
        }

        if (collision.gameObject.tag == "GreenEnemy")
        {
            TakeDamage(1);
            Debug.Log("Player Hit");
        }
    }
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthbar.SetHealth(currentHealth);
    }
}
