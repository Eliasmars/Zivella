using NUnit.Framework.Constraints;
using UnityEngine;
using UnityEngine.InputSystem;

public class movimiento : MonoBehaviour
{
    public float velocidadcaminar = 0.10f;
    public float velocidadcorrer = 0.12f;
    public float velocidadactual;

    public float fuerzaSalto = 5f;
    public Rigidbody2D rb;

    float x, y;
    BoxCollider2D boxcollider;

    void Start()
    {
        x = transform.position.x;
        y = transform.position.y;
        boxcollider = GetComponent<BoxCollider2D>();

        velocidadactual = velocidadcaminar;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
            velocidadactual = velocidadcorrer;
        else
            velocidadactual = velocidadcaminar;

        
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-velocidadactual, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(velocidadactual, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.W) && Mathf.Abs(rb.linearVelocity.y) < 0.01f)
        {
            rb.AddForce(new Vector2(0f, fuerzaSalto), ForceMode2D.Impulse);
        }
    }
}
