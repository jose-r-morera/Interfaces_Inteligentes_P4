using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej3_colision_arana : MonoBehaviour
{
    public ej3_notificador notificador;

    public float speed = 2;
    Vector3 direccion_objetivo;
    public float cercania_objetivo = 0.4f;

    GameObject huevo_objetivo;
    GameObject objeto_referencia;

    public bool seguir_huevo = false;
    public bool seguir_referencia = false;

    public Material nuevo_material;

    void Start()
    {
        notificador.OnCollisionTipo1 += respuestaColisionTipo1;
        notificador.OnCollisionTipo2 += respuestaColisionTipo2;

        huevo_objetivo = GameObject.FindWithTag("huevo_tipo2");
        objeto_referencia = GameObject.FindWithTag("esfera_objetivo");
    }
    // Update is called once per frame
    void Update()
    {
        if (seguir_huevo)
        {
            direccion_objetivo = huevo_objetivo.transform.position - transform.position;

        }
        else if (seguir_referencia)
        {
            direccion_objetivo = objeto_referencia.transform.position - transform.position;
        }

        // Cuando se llega al objetivo se detiene el movimiento
        if (direccion_objetivo.magnitude <= cercania_objetivo)
        {
            seguir_huevo = false;
            seguir_referencia = false;
        }
        else
        {
            transform.Translate(direccion_objetivo.normalized * speed * Time.deltaTime, Space.World);
        }
    }

    // Cuando el cubo toca cualquier araña del grupo 1 
    //se dirigen hacia los huevos del grupo 2
    void respuestaColisionTipo1()
    {
        seguir_huevo = true;
    }

    // Cuando el cubo colisiona con cualquier araña tipo 2, 
    // las arañas en el grupo 1 se acercan a un objeto seleccionado
    void respuestaColisionTipo2()
    {
        seguir_referencia = true;
    }

    void OnCollisionEnter(Collision c)
    {
        GameObject other = c.gameObject;
        if (other.tag == "huevo_tipo2")
        {
            other.GetComponentInChildren<MeshRenderer>().material = nuevo_material;
        }
    }
}
