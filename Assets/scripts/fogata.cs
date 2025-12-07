using UnityEngine;

public class fogata : MonoBehaviour
{
    private bool enColisionConHogera1 = false;
    private bool enColisionConHogera2 = false;
    private bool enColisionConHogera3 = false;
    private bool DesbloqueadoConHogera1 = false;
    private bool DesbloqueadoConHogera2 = false;
    private bool DesbloqueadoConHogera3 = false;
    private GameObject objetoDestino;

    void Update()
    {

        if (enColisionConHogera1 && Input.GetKeyDown(KeyCode.D))
        {
            objetoDestino = GameObject.FindGameObjectWithTag("hogera 2");

            if (DesbloqueadoConHogera2 == true)
            {
                if (objetoDestino != null)
                {

                    transform.position = objetoDestino.transform.position;
                }
            }

        }
        if (enColisionConHogera1 && Input.GetKeyDown(KeyCode.A))
        {
            objetoDestino = GameObject.FindGameObjectWithTag("hogera 3");
            if (DesbloqueadoConHogera3 == true)
            {
                if (objetoDestino != null)
                {

                    transform.position = objetoDestino.transform.position;
                }
            }

        }
        else if (enColisionConHogera2 && Input.GetKeyDown(KeyCode.D))
        {
            objetoDestino = GameObject.FindGameObjectWithTag("hogera 3");

            if (DesbloqueadoConHogera3 == true)
            {
                if (objetoDestino != null)
                {

                    transform.position = objetoDestino.transform.position;
                }
            }

        }
        else if (enColisionConHogera2 && Input.GetKeyDown(KeyCode.A))
        {
            objetoDestino = GameObject.FindGameObjectWithTag("hogera");

            if (DesbloqueadoConHogera1 == true)
            {
                if (objetoDestino != null)
                {

                    transform.position = objetoDestino.transform.position;
                }
            }

        }
        else if (enColisionConHogera3 && Input.GetKeyDown(KeyCode.A))
        {
            objetoDestino = GameObject.FindGameObjectWithTag("hogera 2");

            if (DesbloqueadoConHogera2 == true)
            {
                if (objetoDestino != null)
                {

                    transform.position = objetoDestino.transform.position;
                }
            }

        }
        else if (enColisionConHogera3 && Input.GetKeyDown(KeyCode.D))
        {
            objetoDestino = GameObject.FindGameObjectWithTag("hogera");
            if (DesbloqueadoConHogera1 == true)
            {
                if (objetoDestino != null)
                {

                    transform.position = objetoDestino.transform.position;
                }
            }

        }


    }


    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("hogera"))
        {
            DesbloqueadoConHogera1 = true;
            enColisionConHogera1 = true;
        }
        if (coll.gameObject.CompareTag("hogera 2"))
        {
            DesbloqueadoConHogera2 = true;
            enColisionConHogera2 = true;
        }
        if (coll.gameObject.CompareTag("hogera 3"))
        {
            DesbloqueadoConHogera3 = true;
            enColisionConHogera3 = true;
        }
    }


    private void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("hogera"))
        {
            enColisionConHogera1 = false;
        }
        if (coll.gameObject.CompareTag("hogera 2"))
        {
            enColisionConHogera2 = false;
        }
        if (coll.gameObject.CompareTag("hogera 3"))
        {
            enColisionConHogera3 = false;
        }
    }
}
