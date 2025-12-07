using UnityEngine;

public class enemigo : MonoBehaviour
{
    
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
        if (Vector3.Distance(transform.position, objetivoActual.position) < 0.1f)
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



        // Mensaje simple de ataque
        Debug.Log("El enemigo está atacando al jugador!");
    }
}
