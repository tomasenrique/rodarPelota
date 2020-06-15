using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Para poder reconocer el texto


public class ControladorJugador : MonoBehaviour
{
    private Rigidbody rigidbody;
    public float velocidad; // esta variable se vera en la vista del archivo ControladorJugador en unity
    public Text puntuacion; // Esto sera el texto que mostrara la puntuacion en la pantalla y en la vista de unity se le asigna el objeto 'puntuacion'.

    public Text ganar; // para mostrar el mensaje de termiando. En la vista de unity se le asigna el objeto 'ganar'.

    private int contador; // para poder contar cuando la pelota choca con cada cubo


    public void FixedUpdate() // este metodo esta realcionado con la fisica. (movimiento)
    {
        // Para aplicar el movimiento horizontal y vertical a la pelota
        float movimientoHorizontal = Input.GetAxis("Horizontal"); // valor -1
        float movimientoVertical = Input.GetAxis("Vertical"); // calor 1

        Vector3 movimiento = new Vector3(movimientoHorizontal, 0, movimientoVertical);
        rigidbody.AddForce(movimiento * velocidad); // aqui se aplica la fuerta al objeto rigibody(pelota)
    }

    // Awake is called when the script instance is being loaded
    private void Awake() // aqui el codigo de inicializacion de los componentes
    { 
        rigidbody = GetComponent<Rigidbody>(); // esta es la referencia al componente de rigibody

        contador = 0; // inicializa el contador

        actualizarMarcador(); // inicialica el texto y se concatena el resultado con el valor del contador.

        ganar.gameObject.SetActive(false); // se desactiva el texto de 'terminado' al iniciar el juego
    }



    // OnTriggerEnter is called when the Collider other enters the trigger
    private void OnTriggerEnter(Collider other)
    {
        // En este metodo se detectara la colision entre la pelota y el cubo, siembre que este tenga activado su 'Is Trigger' en Box Collider

        Debug.Log("Colision"); // mostrara un mensaje en consola cuando la pelota choque con el cubo
        Destroy(other.gameObject); // 'other' es el collider del objeto con el que se choca y con esto se eliminara el cubo.

        // cada vez que la pelota choque con un cubo este aumentara en 1 y para poder verlo hay que ir a unity y en el inspector buscar el modo debug.
        contador++;
        actualizarMarcador();// Llamara al metodo que actualizara el marcador

        if(contador >= 10)
        {
            ganar.gameObject.SetActive(true); // aqui cuando se detecte las 10 colisiones se mostrada el mensaje de terminado.
        }


        



    }

    private void actualizarMarcador()
    {
        // Este metodo servira para actualizar el marcador cada vez que la petota choque con un cubo.
        puntuacion.text = "Puntuacion: " + contador; // inicialica el texto y se concatena el resultado con el valor del contador.
    }





    /*
     NOTAS

    - Con Ctrl + Shift + M ==>> se mostraran todos los metodos disponibles
     
     
     */
}
