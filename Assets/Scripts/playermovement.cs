using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    [Range(0,100)]
    public float MaxSpeed, MaxAcceleration;
    [Header("Bounds")]
    public float HorizontalLimit; //se declara estas variables para en clamped sustituirlos por los numeros y asi poder cambiarlos en el inspector de unity
    public float VerticalLimit;

    private float  currentVelocityX, currentVelocityY; // le dara la velocidad actual en todo momento en ambos ejes 

    // Update is called once per frame
    void Update()
    {
        //input
        float h = Input.GetAxisRaw("Horizontal"); //añadimos las teclas de horizontal
        float v = Input.GetAxisRaw("Vertical"); // y la de vertical
        
        //movimiento
        Vector3 dir = new Vector3(h, v).normalized; //la direccion donde nos queremos mover, añadimos las direcciones h v y normalizamos el movimiento diagonal para que la velocidad se a igual en todas direcciones

        // aceleracion (cambio de la velocidad) por cada dimension
        currentVelocityX = Mathf.MoveTowards(currentVelocityX, dir.x * MaxSpeed, MaxAcceleration * Time.deltaTime); //aumenta la velocidad por vector y el resultado se fuarda en currentVelocityX, MaxAcceleration se multiplica por timedeltatime lo cual multiplica la aceleracion por segundo
        currentVelocityY = Mathf.MoveTowards(currentVelocityY, dir.y * MaxSpeed, MaxAcceleration * Time.deltaTime); //lo mismo en el eje Y

        //velocity es el vector que indica la velociidad por segundo...
        Vector3 velocity = new Vector3(currentVelocityX, currentVelocityY);
        //hay que pasarlo a movimiento por cada instante, eso es el desplazamiento
        Vector3 displacement = velocity * Time.deltaTime;

        transform.Translate(displacement);
        //limites
        float xClamped = Mathf.Clamp(transform.position.x, -HorizontalLimit, HorizontalLimit);   //de esta forma se crea limities de movimiento en el eje x dando su valor minimo y maximo
        float yClamped = Mathf.Clamp(transform.position.y, -VerticalLimit, VerticalLimit);    //y aqui se hace lo mismo pero con el eje y


        transform.position = new Vector3(xClamped, yClamped);       //se crea el transform para que se ejecute los limites
    }


}
