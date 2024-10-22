using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej4_colision_arana2 : MonoBehaviour
{
    public ej4_notificador notificador;
    GameObject objeto_referencia;

    void Start()
    {
        notificador.OnCollision += miRespuesta;

        objeto_referencia = GameObject.FindWithTag("referencia");
    }
    // Update is called once per frame
    void Update()
    {
    }
    void miRespuesta()
    {
        transform.LookAt(objeto_referencia.transform);
    }
}
