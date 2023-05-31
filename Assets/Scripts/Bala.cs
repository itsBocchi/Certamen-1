using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public float velocidad = 10f;

    void Start()
    {
        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(0.0f, velocidad * Time.deltaTime, 0.0f, Space.Self);
    }

}
