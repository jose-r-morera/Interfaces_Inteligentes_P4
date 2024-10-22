using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej1_esfera_tipo2 : MonoBehaviour
{
    public ej1_notificador notificador;

    public float speed = 2;
    Vector3 direccion_cilindro;
    GameObject cilindro; 

    bool siguiendo_cilindro = false;

    void Start()
    {
        notificador.OnCollision += miRespuesta;
        cilindro = GameObject.FindWithTag("cilindro_verde");
    }
    // Update is called once per frame
    void Update()
    {
        if (siguiendo_cilindro) {
            direccion_cilindro = cilindro.transform.position - transform.position; 
            transform.Translate(direccion_cilindro.normalized * speed * Time.deltaTime, Space.World);
        }
    }
    
    void miRespuesta(){
        siguiendo_cilindro = true;
    }

}
