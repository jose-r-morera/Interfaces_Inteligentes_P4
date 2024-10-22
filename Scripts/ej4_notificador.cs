using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej4_notificador : MonoBehaviour
{
    // delegado para notificar
    public delegate void mensaje();
    public event mensaje OnCollision;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "referencia") {
            OnCollision();
        }
    }
}
