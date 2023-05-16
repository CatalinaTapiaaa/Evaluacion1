using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float velocidad = 5f;
    public int vida;

    public GameObject proyectil;
    public Transform puntero;

    float x, y;

    void Start()
    {
        vida = 3;
    }

    void Update()
    {
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");

        transform.position += new Vector3(x, y) * velocidad * Time.deltaTime;

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(proyectil, puntero.position, Quaternion.identity);
        }

        if (vida <= 0)
        {
            Debug.Log("Esta Muerto");
            Destroy(gameObject, 2f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player Projectile"))
        {

        }
        else
        {
            vida -= 1;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        vida -= 1;
    }
}
