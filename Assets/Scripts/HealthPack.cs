using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPack : MonoBehaviour
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
        if(collision.CompareTag("Health")){
            Debug.Log("Daga usa cura");
            currentHP += 10;


            if(currentHP <= 5){
                currentHP = 30;
                Debug.Log("curado");
            }
 
            
            
        }

        
    }
}
