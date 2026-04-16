using UnityEngine;

public class Jefe1 : MonoBehaviour
{
    public barravida barraVida;
    public Transform puntoA;
    public Transform puntoB;
    public Transform jugador;
    public float vida = 200;

    public float velocidad = 2f;
    public float distanciaAtaque = 1.5f;
    float tiempoEntreAtaques = 1.2f;
    float timerAtaque;
    public float distanciaPersegir = 10f;

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
        timerAtaque += Time.deltaTime;

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

        if (timerAtaque >= tiempoEntreAtaques)
        {
            barravida barra = jugador.GetComponent<barravida>();

            if (barra != null)
            {
                barra.recibirDaño(7); 
            }

            timerAtaque = 0f;
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
        if (collision.gameObject.CompareTag("plataformaJ"))
        {
            Physics2D.IgnoreCollision(
                collision.collider,
                GetComponent<Collider2D>()
            );
        }
    }
}
