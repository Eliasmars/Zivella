using UnityEngine;
using UnityEngine.EventSystems;

public class enemigo : MonoBehaviour
{
    public barravida barraVida;       
    public Transform puntoA;        
    public Transform puntoB;         
    public Transform jugador;         
    public float vida = 100;

    public float velocidad = 2f;      
    public float distanciaAtaque = 1.5f;
    public float distanciaPersegir = 15f;

    private Transform objetivoActual;
   

    void Start()
    {
        
        objetivoActual = puntoA;
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
        // Moverse hacia el punto actual
        transform.position = Vector3.MoveTowards(
            transform.position,
            objetivoActual.position,
            velocidad * Time.deltaTime
        );

        // Si llega al punto, cambiar al otro
        if (Vector3.Distance(transform.position, objetivoActual.position) < 0.5f)
        {
            if (objetivoActual == puntoA)
            {
                objetivoActual = puntoB;
            }
            else
            {
                objetivoActual = puntoA;
            }
        }
    }
    void SeguirJugador()
    {
        float direccion = Mathf.Sign(jugador.position.x - transform.position.x);
        transform.position += Vector3.right * direccion * velocidad * Time.deltaTime;
    }
    void Atacar()
    {
       
            Debug.Log("El enemigo está atacando al jugador!");

    }

    //formula de daño para el jugador
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            vida -= 20;
        }
    }

}
