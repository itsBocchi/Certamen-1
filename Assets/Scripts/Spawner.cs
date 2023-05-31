using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    float timer = 0f;
    public GameObject enemy;
    PlayerController player;

    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0 && player != null)
        {
            Instantiate(enemy, new Vector2(Random.Range(-8f, 8f),Random.Range(-4f, 4f)), Quaternion.identity);
            timer = Random.Range(0f, 3f);
        }
    }
}
