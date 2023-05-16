using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Satelite : MonoBehaviour
{
    public int vida;
    public GameObject laser;
    public Transform puntero;
    float tiempo;

    void Start()
    {
        vida = 20;
        tiempo = 0;
    }

    void Update()
    {
        tiempo += Time.deltaTime;

        if (tiempo >= 5)
        {
            Instantiate(laser, puntero.position, Quaternion.identity);
            tiempo = 0;
        }

        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player Projectile"))
        {
            vida -= 1;
        }
    }
}
