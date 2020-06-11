using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorCamara : MonoBehaviour
{
    /* Esta variable sera cualquier objeto que este en la vista de SimpleScene, en esta caso la pelota.
     * A esta variable hay que asignarle su valor por medio de la vista en unity, agregando jugador a jugador en la vista   */
    public GameObject jugador;
    private Vector3 posicionRelativa; // Esta variable contendra la distancia de la camara a la pelota en cada una de las 3 coordenadas


    // Start is called before the first frame update
    void Start()
    {
        /* Aqui se restara la posicion de la pelota a la posicion de la camara. 
         * 'transform.position' es la posicion de la camara y 'jugador.transform.position' es la posicion de la pelota.   */
        posicionRelativa = transform.position - jugador.transform.position;

    }

    // LateUpdate is called every frame, if the Behaviour is enabled
    private void LateUpdate()
    {
        /* Aqui se configura la camara para que siga a la pelota, en donde 'transform.position' que es la camara tendra un valor de 
         * la pelota menos la posicion relativa de ambas        */
        transform.position = jugador.transform.position + posicionRelativa;
    }
}
