using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
        // Este metodo es para la pausa del juego
        if (Input.GetKeyDown(KeyCode.Escape)) // cuando se presiona la tecla 'Escape', y se asigna a cualquier objeto en la vista de unity
        {
            Application.Quit(); // en este caso se le asignara a el jugador
        }

        
    }
}
