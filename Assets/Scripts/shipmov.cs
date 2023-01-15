using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class shipmov : MonoBehaviour 
{
    
   
    Vector3 v1;
    public float Speed;
    public GameObject bullet;
    public Transform SpawnPoint1, SpawnPoint2;
    private void Start()      
    {
        
       
    }

    
    private void Update()
    {
        //v1 = transform.position;
        //Debug.Log(v1.magnitude);  

        float h = Input.GetAxis("Horizontal"); 
        float v = Input.GetAxis("Vertical"); 

        //v1 = new Vector3(h, 0, v); 
        v1 = Vector3.right * h + Vector3.up * v; 
        v1.Normalize(); 

        transform.position += v1 * Time.deltaTime * Speed;

        //Instantiate(bullet, transform.position, Quaternion.identity);

        if (Input.GetKey(KeyCode.Space)) //KeyCode sirve para pulsar el espacio
        {
            
            GameObject go = Instantiate(bullet, SpawnPoint1.position, bullet.transform.rotation); //quaternion es una clase de rotaccion, si le llamas identity deja la rotacion en 0 0 0
            GameObject go1 = Instantiate(bullet, SpawnPoint2.position, bullet.transform.rotation);
            Destroy(go, 2); //le añadimos tiempo para que el obejto desaparezca
            Destroy(go1, 2);
        }


    }
}
