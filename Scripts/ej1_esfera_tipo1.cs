using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej1_esfera_tipo1 : MonoBehaviour
{
    public ej1_notificador notificador;

    public float speed = 2;
    Vector3 direccion_esfera;
    GameObject esfera; 

    bool siguiendo_esfera = false;

    void Start()
    {
        notificador.OnCollision += miRespuesta;
        esfera = GameObject.FindWithTag("esfera_objetivo");
    }
    // Update is called once per frame
    void Update()
    {
        if (siguiendo_esfera) {
            direccion_esfera = esfera.transform.position - transform.position; 
            transform.Translate(direccion_esfera.normalized * speed * Time.deltaTime, Space.World);
        }
    }
    
    void miRespuesta(){
        siguiendo_esfera = true;
    }

}
