using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ej6_puntuacion : MonoBehaviour
{
    public TMP_Text texto_puntuacion;
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
            texto_puntuacion.SetText("Puntuación: " + puntuacion);
            // Se mueve aleatoriamente en los ejes x y z
            other.transform.Translate(Random.Range(movement_minimum, movement_maximum), 0, Random.Range(movement_minimum, movement_maximum));
        } else if (other.tag == "huevo_tipo2") {
            puntuacion += 10;
           texto_puntuacion.SetText("Puntuación: " + puntuacion);
            other.transform.Translate(Random.Range(movement_minimum, movement_maximum), 0, Random.Range(movement_minimum, movement_maximum));
        }
    }
}
