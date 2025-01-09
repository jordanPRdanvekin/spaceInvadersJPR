using UnityEngine;

public class moverNave : MonoBehaviour
{
    [SerializeField]
    public GameObject nave; // Referencia al objeto de la nave
    [SerializeField]
    float vel = 0.02f; // Velocidad de movimiento de la nave
    [SerializeField]
    float lim = 12f; // L�mite en el eje X para evitar que la nave salga de pantalla
    public static Vector3 posnav = new Vector3(0f, -7f, 0f); // Posici�n inicial de la nave

    // Inicializa la nave, activ�ndola y ubic�ndola en su posici�n inicial
    void Start()
    {
        nave.SetActive(true);
        nave.transform.position = posnav;
    }

    // Gestiona el movimiento horizontal de la nave en cada frame, seg�n las teclas A y D
    void Update()
    {
        // Mueve la nave hacia la izquierda mientras no supere el l�mite negativo
        if (Input.GetKey(KeyCode.A))
        {
            if (nave.transform.position.x > -lim)
            {
                posnav = new Vector3(nave.transform.position.x - vel, -7f, 0f);
                nave.transform.position = posnav;
            }
        }
        // Mueve la nave hacia la derecha mientras no supere el l�mite positivo
        else if (Input.GetKey(KeyCode.D))
        {
            if (nave.transform.position.x < lim)
            {
                posnav = new Vector3(nave.transform.position.x + vel, -7f, 0f);
                nave.transform.position = posnav;
            }
        }
    }
}
