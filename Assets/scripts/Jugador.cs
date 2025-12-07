using NUnit.Framework.Constraints;
using UnityEngine;
using UnityEngine.InputSystem;

public class movimiento : MonoBehaviour
{
    public float velocidadcaminar = 0.4f;
    public float velocidadcorrer = 0.8f;
    public float velocidadactual;

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
            transform.position += new Vector3(0, velocidadcaminar, 0);
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
            transform.position += new Vector3(-velocidadactual, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(velocidadactual, 0, 0);
        }

        
    }
}
