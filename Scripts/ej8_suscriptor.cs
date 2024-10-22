using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej8_suscriptor : MonoBehaviour
{
    public ej8_notificador notificador;
    public bool seguir = true;
    public float speed = 2.0f;
    GameObject jugador;
    Vector3 direccion_jugador;

    void Start()
    {
        notificador.OnPowerup += miRespuesta;

        jugador = GameObject.FindWithTag("Player");
    }
    // Update is called once per frame
    void Update()
    {
        transform.LookAt(jugador.transform);

        if (seguir) {
            direccion_jugador = jugador.transform.position - transform.position; 
            transform.Translate(direccion_jugador.normalized * speed * Time.deltaTime, Space.World);
        }
    }
    void miRespuesta()
    {
        seguir = false;
    }
}
