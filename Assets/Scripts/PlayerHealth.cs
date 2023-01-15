using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{   
    public GameObject explosion;
    public GameObject smoke;
    public int MaxHP;
    private int currentHP;
    public Transform SpawnExplosion;
    public Transform SpawnSmoke;
    // Start is called before the first frame update
    void Start()
    {
        currentHP = MaxHP;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {   
        if(collision.CompareTag("Enemy")){
            Debug.Log("Mina hace 50 de daño");
            currentHP -= 50;

            if(currentHP <= 0)
            {
                GameObject boom = Instantiate(explosion, SpawnExplosion.position, Quaternion.identity);
                GameObject smok = Instantiate(smoke, SpawnExplosion.position, Quaternion.identity);
                explosion.SetActive(true);
                smoke.SetActive(true);
                Debug.Log("¡TE MATARON!");
                Destroy(gameObject);

            }
                
        }
    }
}