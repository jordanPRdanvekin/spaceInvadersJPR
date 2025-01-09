using UnityEngine;

public class moverNave : MonoBehaviour
{
    [SerializeField]
    public GameObject nave; // Referencia al objeto de la nave
    [SerializeField]
    float vel = 0.02f; // Velocidad de movimiento de la nave
    [SerializeField]
    float lim = 12f; // Límite en el eje X para evitar que la nave salga de pantalla
    public static Vector3 posnav = new Vector3(0f, -7f, 0f); // Posición inicial de la nave

    // Inicializa la nave, activándola y ubicándola en su posición inicial
    void Start()
    {
        nave.SetActive(true);
        nave.transform.position = posnav;
    }

    // Gestiona el movimiento horizontal de la nave en cada frame, según las teclas A y D
    void Update()
    {
        // Mueve la nave hacia la izquierda mientras no supere el límite negativo
        if (Input.GetKey(KeyCode.A))
        {
            if (nave.transform.position.x > -lim)
            {
                posnav = new Vector3(nave.transform.position.x - vel, -7f, 0f);
                nave.transform.position = posnav;
            }
        }
        // Mueve la nave hacia la derecha mientras no supere el límite positivo
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
