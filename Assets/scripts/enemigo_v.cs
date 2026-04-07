using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class enemigo_v : MonoBehaviour
{
    private bool puedeAtacar = true;
    public float cooldownAtaque = 2f;
    public barravida barraVida;
    public Transform puntoA;
    public Transform puntoB;
    public Transform jugador;
    public float vida = 100;

    public float velocidad = 3f;
    public float distanciaAtaque = 4f;
    public float distanciaPersegir = 15f;

    private Transform objetivoActual;
    private Animator anim;

    SpriteRenderer spriteRenderer;


    void Start()
    {

        objetivoActual = puntoA;
        anim = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // Medir la distancia al jugador
        float distancia = Vector3.Distance(transform.position, jugador.position);


        if (distancia <= distanciaAtaque)
        {
            Atacar();

        }
        else if (distancia <= distanciaPersegir)
        {

            SeguirJugador();

        }
        else
        {
            Patrullar();

        }

        if (vida <= 0)
        {
            Destroy(gameObject);
        }

    }
    void Patrullar()
    {
        anim.SetInteger("atacar", 0);
        transform.position = Vector3.MoveTowards(
            transform.position,
            objetivoActual.position,
            velocidad * Time.deltaTime
        );

        // Si llega al punto, cambiar al otro
        if (Vector3.Distance(transform.position, objetivoActual.position) < 0.1f)
        {
            if (objetivoActual.position == puntoA.position)
            {
                objetivoActual = puntoB;
                spriteRenderer.flipX = true;
            }
            else
            {
                objetivoActual = puntoA;
                spriteRenderer.flipX = false;
            }
        }
    }
    void SeguirJugador()
    {
        anim.SetInteger("atacar", 0);

        MirarJugador();

        float direccion = Mathf.Sign(jugador.position.x - transform.position.x);
        transform.position += Vector3.right * direccion * velocidad * Time.deltaTime;
    }
    void Atacar()
    {
        anim.SetInteger("atacar", 1);

        MirarJugador();

        float distancia = Vector3.Distance(transform.position, jugador.position);

        if (distancia <= distanciaAtaque && puedeAtacar)
        {
            barravida barra = jugador.GetComponent<barravida>();

            if (barra != null )
            {
                StartCoroutine(Veneno(barra));
                
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "espada")
        {
            vida -= 20;
        }
    }
    void MirarJugador()
    {
        if (jugador.position.x > transform.position.x)
        {
            spriteRenderer.flipX = true; // mira derecha
        }
        else
        {
            spriteRenderer.flipX = false; // mira izquierda
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemigo (regular)"))
        {
            Physics2D.IgnoreCollision(
                collision.collider,
                GetComponent<Collider2D>()
            );
        }
        
    }
    IEnumerator Veneno(barravida barra)
    {
        puedeAtacar = false;

        SpriteRenderer sr = barra.GetComponent<SpriteRenderer>();

        barra.recibirDaño(10);

        sr.color = Color.green;

        yield return new WaitForSeconds(2f);
        barra.recibirDaño(5);

        yield return new WaitForSeconds(2f);
        barra.recibirDaño(5);

        sr.color = new Color(183f / 255f, 133f / 255f, 8f / 255f);

        yield return new WaitForSeconds(cooldownAtaque);

        puedeAtacar = true;
    }
}
