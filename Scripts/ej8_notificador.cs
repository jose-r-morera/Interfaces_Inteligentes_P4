using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej8_notificador : MonoBehaviour
{
    int puntuacion = 0;
    public float movement_minimum = -5;
    public float movement_maximum = 5;
    // Start is called before the first frame update

    public delegate void mensaje();
    public event mensaje OnPowerup;


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
            // Se mueve aleatoriamente en los ejes x y z
            other.transform.Translate(Random.Range(movement_minimum, movement_maximum), 0, Random.Range(movement_minimum, movement_maximum));
            OnPowerup();
        }
    }
}
