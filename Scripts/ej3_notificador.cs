using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej3_notificador : MonoBehaviour
{
    // delegado para notificar
    public delegate void mensaje();
    public event mensaje OnCollisionTipo1;
    public event mensaje OnCollisionTipo2;

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
        if (other.tag == "arana_tipo1") {
            OnCollisionTipo1();
        } else if (other.tag == "arana_tipo2") {
            OnCollisionTipo2();
        }
    }
}
