using NUnit.Framework.Constraints;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Jugador : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Animator _animator;

    public barravida barravida;
    public float velocidadcaminar = 10f;
    public float velocidadcorrer = 12f;
    public float velocidadactual;
    private float xPosUltiFrame;

    float x, y;
    BoxCollider2D boxcollider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        x = transform.position.x;
        y = transform.position.y;
        boxcollider = GetComponent<BoxCollider2D>();

        velocidadactual = velocidadcaminar;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
            velocidadactual = velocidadcorrer;
        else
            velocidadactual = velocidadcaminar;


        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 18 * Time.deltaTime, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            boxcollider.offset = new Vector2(0, -0.03561386f);
            boxcollider.size = new Vector2(1f, 0.5f);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            boxcollider.offset = new Vector2(0, 0.2113333f);
            boxcollider.size = new Vector2(1f, 1f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-velocidadactual * Time.deltaTime, 0, 0);
            _animator.SetBool("IsCaminando", true);
        }
        if (Input.GetKey(KeyCode.D))
        {
            
            transform.position += new Vector3(velocidadactual * Time.deltaTime, 0, 0);
            _animator.SetBool("IsCaminando", true);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            _animator.SetBool("IsCaminando", false);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            _animator.SetBool("IsCaminando", false);
        }

        if (Input.GetKey(KeyCode.V))
        {
            _animator.SetBool("IsAtaque", true);
        }
        if (Input.GetKeyUp(KeyCode.V))
        {
            _animator.SetBool("IsAtaque", false);
        }

        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Trampa")
        {
            barravida.recibirDaño(5);
        }

        if (collision.gameObject.tag == "Enemigo (regular)")
        {
            barravida.recibirDaño(10);
        }

        if (collision.gameObject.tag == "Enemigo(Jefe)")
        {
            barravida.recibirDaño(15);
        }
    }

    private void FlipCaballeroX()
    {
        if (transform.position.x > xPosUltiFrame)

        {
            spriteRenderer.flipX = false;
        }
        else if (transform.position.x < xPosUltiFrame)
        {
            spriteRenderer.flipX = true;
        }
        xPosUltiFrame = transform.position.x;
    }

}
