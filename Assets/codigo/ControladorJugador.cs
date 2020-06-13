using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJugador : MonoBehaviour
{
    private Rigidbody rigidbody;
    public float velocidad; // esta variable se vera en la vista del archivo ControladorJugador en unity



    public void FixedUpdate() // este metodo esta realcionado con la fisica.
    {
        // Para aplicar el movimiento horizontal y vertical a la pelota
        float movimientoHorizontal = Input.GetAxis("Horizontal"); // valor -1
        float movimientoVertical = Input.GetAxis("Vertical"); // calor 1

        Vector3 movimiento = new Vector3(movimientoHorizontal, 0, movimientoVertical);
        rigidbody.AddForce(movimiento * velocidad); // aqui se aplica la fuerta al objeto rigibody(pelota)
    }

    public void Awake() // aqui el codigo de inicializacion del componente
    {
        rigidbody = GetComponent<Rigidbody>(); // esta es la referencia al componente de rigibody
    }

    // OnTriggerEnter is called when the Collider other enters the trigger
    private void OnTriggerEnter(Collider other)
    {
        // En este metodo se detectara la colision entre la pelota y el cubo, siembre que este tenga activado su 'Is Trigger' en Box Collider

        Debug.Log("Colision"); // mostrara un mensaje en consola cuando la pelota choque con el cubo
        Destroy(other.gameObject); // 'other' es el collider del objeto con el que se choca y con esto se eliminara el cubo.


    }





    /*
     NOTAS

    - Con Ctrl + Shift + M ==>> se mostraran todos los metodos disponibles
     
     
     */
}
