using UnityEngine;
using UnityEngine.EventSystems;

public class enemigo : MonoBehaviour
{
    public barravida barraVida;       //el nombre del script para encontrarlo
    public Transform puntoA;          // Primer punto de patrulla
    public Transform puntoB;          // Segundo punto de patrulla
    public Transform jugador;         // Referencia al jugador

    public float velocidad = 2f;      // Velocidad del enemigo
    public float distanciaAtaque = 1.5f; // Distancia para atacar

    private Transform objetivoActual; // Hacia dónde va el enemigo

    void Start()
    {
        // Comenzamos yendo al punto A
        objetivoActual = puntoA;
    }

    // Update is called once per frame
    void Update()
    {
        // Medir la distancia al jugador
        float distancia = Vector3.Distance(transform.position, jugador.position);

        // Si está suficientemente cerca, ataca
        if (distancia <= distanciaAtaque)
        {
            Atacar();
            return;
        }

        // Si no está cerca, patrulla
        Patrullar();
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

    void Atacar()
    {
        if (jugador.transform.position.x > transform.position.x)
        {

            transform.position = new Vector3(transform.position.x + 0.001f, transform.position.y, transform.position.z);
            Debug.Log("El enemigo está atacando al jugador!");
        }

        if (jugador.transform.position.x < transform.position.x)
        {

            transform.position = new Vector3(transform.position.x - 0.001f, transform.position.y, transform.position.z);
            Debug.Log("El enemigo está atacando al jugador!");
        }
        
    }

    //formula de daño para el jugador
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            barraVida.Daño(10);
        }
    }


}
