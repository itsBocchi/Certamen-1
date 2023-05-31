using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidad = 5f;
    public int vidas = 3;
    public int puntos = 0;
    public GameObject bala;
    public Transform cañon;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            gameObject.transform.Rotate(0.0f, 0.0f, 90.0f, Space.Self);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            gameObject.transform.Rotate(0.0f, 0.0f, -90.0f, Space.Self);
        }
        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.Translate(0.0f, velocidad * Time.deltaTime, 0.0f, Space.Self);
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(bala, cañon.position, gameObject.transform.rotation);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemigo")
        {
            vidas--;
            if (vidas <= 0)
            {
                Debug.Log("GAME OVER");
                Debug.Log("Puntaje: " + puntos);
                Destroy(gameObject);
            }
        }
    }
}
