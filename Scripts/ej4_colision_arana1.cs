using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej4_colision_arana1 : MonoBehaviour
{
    public ej4_notificador notificador;
    public float distancia_objetivo = 0.9f;

    GameObject objeto_referencia;

    void Start()
    {
        notificador.OnCollision += miRespuesta;
        objeto_referencia = GameObject.FindWithTag("huevo_objetivo");
    }
    // Update is called once per frame
    void Update()
    {
    }
    void miRespuesta()
    {
        Vector3 desplazamiento_objetivo = objeto_referencia.transform.position - transform.position;
        Vector3 posicion_objetivo = desplazamiento_objetivo - desplazamiento_objetivo.normalized * distancia_objetivo;
        transform.Translate(posicion_objetivo, Space.World);
    }
}
