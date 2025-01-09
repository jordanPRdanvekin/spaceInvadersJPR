using Unity.VisualScripting;
using UnityEngine;

public class proyectil : MonoBehaviour
{
    [SerializeField]
    GameObject proyectilB;
    [SerializeField]
    float velbal = 1f;
    float tiembal = 3f;
    Rigidbody rbala;
    [SerializeField]
    Transform direccion;

    // Start is called before the first frame update
    void Start()
    {
        rbala = GetComponent<Rigidbody>();
        //Destroy(gameObject,tiembal);
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            disparo();
        }
    }
    void FixedUpdate()
    {
        rbala.velocity = moverNave.posnav.normalized * velbal;
    }
    //void OnTriggerEnter(Collider)
    //{
        //Destroy(gameObject);
    //}
    void disparo()
    {
        Instantiate(proyectilB, direccion.transform); 
    }
}
