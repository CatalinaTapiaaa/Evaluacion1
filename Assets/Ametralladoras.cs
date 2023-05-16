using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ametralladoras : MonoBehaviour
{
    public int vida;
    public GameObject proyectilEnemigo;
    public Transform puntero;
    float tiempo;
    float tiempoDelay;
    float tiempoAtaque;
    private float aleatorio;

    void Start()
    {
        vida = 10;
        tiempo = 0;
        tiempoDelay = 0;
        tiempoAtaque = 0;
    }

    void Update()
    {
        tiempo += Time.deltaTime;

        if (tiempo >= 2.5)
        {
            Ataque();
            tiempoAtaque += Time.deltaTime;

            if (tiempoAtaque >= 2.5)
            {
                tiempo = 0;
                tiempoAtaque = 0;
            }

        }

        if (vida <= 0)
        {
            Destroy (gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player Projectile"))
        {
            vida -= 1;
        }
    }

    void Ataque()
    {
        tiempoDelay += Time.deltaTime;

        if (tiempoDelay >= 0.3)
        {
            Instantiate(proyectilEnemigo, puntero.position, Quaternion.identity);
            tiempoDelay = 0;
        }
    }
}

