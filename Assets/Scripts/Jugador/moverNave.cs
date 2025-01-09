using UnityEngine;

public class moverNave : MonoBehaviour
{
    [SerializeField]
    public GameObject nave;
    [SerializeField]
    float vel = 0.02f;
    [SerializeField]
    float lim = 12f;
    public static Vector3 posnav = new Vector3(0f, -7f, 0f);
    // Start is called before the first frame update
    void Start()
    {
        nave.SetActive(true);
        nave.transform.position = posnav;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            if (nave.transform.position.x > -lim)
            {
                posnav = new Vector3(nave.transform.position.x - vel, -7, 0f);
                nave.transform.position = posnav;
            }

        }
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
