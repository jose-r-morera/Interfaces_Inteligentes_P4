using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej5_puntuacion : MonoBehaviour
{
    int puntuacion = 0;
    public float movement_minimum = -5;
    public float movement_maximum = 5;
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
        if (other.tag == "huevo_tipo1") {
            puntuacion += 5;
            Debug.Log("Puntuación: " + puntuacion);
            // Se mueve aleatoriamente en los ejes x y z
            other.transform.Translate(Random.Range(movement_minimum, movement_maximum), 0, Random.Range(movement_minimum, movement_maximum));
        } else if (other.tag == "huevo_tipo2") {
            puntuacion += 10;
            Debug.Log("Puntuación: " + puntuacion);
            other.transform.Translate(Random.Range(movement_minimum, movement_maximum), 0, Random.Range(movement_minimum, movement_maximum));
        }
    }
}
