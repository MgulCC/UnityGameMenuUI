using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int MaxHP;
    private int currentHP;
    // Start is called before the first frame update
    void Start()
    {
        currentHP = MaxHP;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("¡MINA ACTIVADA!");
            currentHP -= 10;

            if (currentHP <= 0)
            {
                Destroy(gameObject);

            }

        }
    }
}
