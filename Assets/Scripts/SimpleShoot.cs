using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleShoot : MonoBehaviour
{
    public GameObject bullet; //se crea el objeto
    public float Cooldown; //y el refresco
    public Transform SpawnPoint1, SpawnPoint2;

    private float cdCounter;
    // Start is called before the first frame update
    void Start()
    {
        cdCounter = Cooldown;
    }

    // Update is called once per frame
    void Update()
    {
        cdCounter += Time.deltaTime;

        if (Input.GetKey(KeyCode.Space) && cdCounter > Cooldown)
        {
            //instanciar (crear) la bala
            GameObject go = Instantiate(bullet, SpawnPoint1.position, Quaternion.identity);
            GameObject go1 = Instantiate(bullet, SpawnPoint2.position, Quaternion.identity);
            Destroy(go, 2);
            Destroy(go1, 2);
            cdCounter = 0;
        }

    }
}
