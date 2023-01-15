using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroll : MonoBehaviour
{   
    public SpriteRenderer graphic;
    public float Speed;
    private float gfxSize;
    private float initialYPos;
    private float yLimit;

    // Start is called before the first frame update
    void Start()
    {
        //guardamos lo largo que mide el gráfico y lo multiplicamos por su escala
        gfxSize = graphic.bounds.size.y * graphic.transform.localScale.y;
        //guardamos la posición inicial
        initialYPos = transform.position.y;
        //y guardamos la cantidad de distancia que debe recorrer el gráfico antes de volver a su posición inicial
        yLimit = initialYPos - gfxSize;
    }

    // Update is called once per frame
    void Update()
    {
        //movemos el gráfico hacia abajos
        transform.Translate(Vector3.up * Time.deltaTime * -Speed);

        //comprobamos que el gráfico haya alcanzado el límitie inferior
        if (transform.position.y < yLimit)
        {
            //y lo volvemos a llevar a donde estaba inicialmente
            transform.position = new Vector3(transform.position.x, initialYPos, transform.position.z);
        }
        
    }
}
