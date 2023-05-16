using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    public float velocidad = 10f;
    float tiempo;

    void Start()
    {
        tiempo = 0;
    }

    void Update()
    {
        transform.position += transform.up * velocidad * Time.deltaTime;

        tiempo += Time.deltaTime;

        if (tiempo >= 3)
        {
            Destroy(gameObject);
            tiempo = 0;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
