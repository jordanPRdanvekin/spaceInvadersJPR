using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salud : MonoBehaviour
{
    [SerializeField]
    private float vida = 5f;

    [SerializeField]
    private GameObject explotar; // Prefab de explosión
    [SerializeField]
    int destruyeEn = 4;

    void Update()
    {
        // Si la vida llega a 0 o menos, destruye el objeto e instancia una explosión
        if (vida <= 0f)
        {
            Explode();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Si colisiona con un objeto con la etiqueta "Bala", resta 1 de vida y destruye la bala
        if (collision.gameObject.CompareTag("Bala"))
        {
            vida -= 1f;
            Destroy(collision.gameObject);
        }
    }

    private void Explode()
    {
        // Instancia el prefab de la explosión en la posición y rotación actuales
        GameObject explosion = Instantiate(explotar, transform.position, transform.rotation);

        // Escalar y rotar la explosión con LeanTween
        explosion.transform.localScale = Vector3.zero; // La escala inicial es cero
        LeanTween.scale(explosion, transform.localScale, 0.5f); // Escala al tamaño original en 0.5 segundos

        // Destruye la explosión tras x segundo
        Destroy(explosion, destruyeEn);

        // Destruye el objeto original
        Destroy(gameObject);
    }
}


