using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiroCubo : MonoBehaviour
{
    private Vector3 rotacion = new Vector3(15, 30, 45); // Rotacion para el cubo

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Time.deltaTime almacena el tiempo en segundo para un fotograma, es para saber cuento pasa entre un fotograma y otro
        transform.Rotate(rotacion * Time.deltaTime);
    }
}
