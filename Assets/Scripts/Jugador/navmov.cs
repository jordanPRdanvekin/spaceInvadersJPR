using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class navmov : MonoBehaviour
{
    [SerializeField]
    private GameObject nave; // Referencia al objeto de la nave
    [SerializeField]
    private float vel = 0.02f; // Velocidad de movimiento
    [SerializeField]
    private float lim = 12f; // Límite en el eje X

    // Posición inicial de la nave
    private Vector3 posnav = new Vector3(0f, -7f, 0f);

    void Start()
    {
        nave.SetActive(true);
        nave.transform.position = posnav;
    }

    void Update()
    {
        // Obtiene la entrada del eje horizontal (-1 para izquierda, 1 para derecha)
        float input = Input.GetAxis("Horizontal");

        // Calcula la nueva posición en el eje X
        float nuevaPosX = nave.transform.position.x + input * vel;

        // Restringe la posición manualmente entre los límites
        if (nuevaPosX < -lim)
        {
            nuevaPosX = -lim;
        }
        else if (nuevaPosX > lim)
        {
            nuevaPosX = lim;
        }

        // Actualiza la posición de la nave
        posnav = new Vector3(nuevaPosX, -7f, 0f);
        nave.transform.position = posnav;
    }
}
