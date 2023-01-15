using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_text : MonoBehaviour
{
    public TextMeshProUGUI content;
    public int MaxHP;
    private int currentHP;
    private float count;

    // Start is called before the first frame update
    void Start()
    {
        currentHP = MaxHP;
        //playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<currentHP>();
    }

    // Update is called once per frame
    void Update()
    {
        count += currentHP;
        content.text = count.ToString("F2"); //f2 saca los dos primeros decimales
        content.text = ("V0.0001");
    }


    /* if(("player")){
            Debug.Log("Mina hace 50 de daño");
            currentHP -= 50;

            if(currentHP <= 0)
            {
                //GameObject boom = Instantiate(explosion, SpawnExplosion.position, Quaternion.identity);
                //GameObject smok = Instantiate(smoke, SpawnExplosion.position, Quaternion.identity);
                //explosion.SetActive(true);
                //smoke.SetActive(true);
                Debug.Log("¡TE MATARON!");
                Destroy(gameObject);
            }
                
     }*/

}