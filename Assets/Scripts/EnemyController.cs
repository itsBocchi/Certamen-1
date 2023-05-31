using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    int vidas;
    PlayerController player;

    void Start()
    {
        vidas = Random.Range(3,6);
        player = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (vidas <= 0)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Projectile")
        {
            vidas--;
            player.puntos += 10;
            Debug.Log("Puntaje: " + player.puntos);
            Destroy(other.gameObject);
        }
    }
}
