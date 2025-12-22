using UnityEngine;

public class Jefe1 : MonoBehaviour
{
    public barravida barraVida;       
    public Transform puntoA;          
    public Transform puntoB;         
    public Transform jugador;        
    public float vida = 200;

    public float velocidad = 3f;      
    public float distanciaAtaque = 4f; 

    private Transform objetivoActual;
    private Animator anim;

    void Start()
    {
        
        objetivoActual = puntoA;
        anim = GetComponent<Animator>();
    }

    
    void Update()
    {
        
        float distancia = Vector3.Distance(transform.position, jugador.position);

       
        if (distancia <= distanciaAtaque)
        {
            Atacar();
            return;
        }

        // Si no está cerca, patrulla
        Patrullar();

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

        anim.SetInteger("AtaqueJefe", 1);
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
