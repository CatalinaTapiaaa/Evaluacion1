using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torretas : MonoBehaviour
{
    public int vida;
    public GameObject proyectilEnemigo;
    public Transform puntero;
    float tiempo;
    private float aleatorio;

    void Start()
    {
        vida = 15;
        tiempo = 0;
        aleatorio = Random.Range(1f, 2f);
    }

    void Update()
    {
        tiempo += Time.deltaTime;

        if (tiempo >= aleatorio)
        {
            Instantiate(proyectilEnemigo, puntero.position, Quaternion.identity);
            tiempo = 0;
            aleatorio = Random.Range(1f, 2f);
        }

        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player Projectile"))
        {
            vida -= 1;
        }
    }
}
