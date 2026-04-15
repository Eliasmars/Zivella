using UnityEngine;
using UnityEngine.SceneManagement;
public class Puertas : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D coll)
    {

        //Mapa 1
        if (coll.gameObject.CompareTag("Puerta inicial"))
        {
            SceneManager.LoadScene("Sala 2");

        }
        else if (coll.gameObject.CompareTag("Puerta spawn"))
        {
            SceneManager.LoadScene("Sala spawn");
        }
        else if (coll.gameObject.CompareTag("puerta 3"))
        {
            SceneManager.LoadScene("Sala 3 vertical 1");
        }
        else if (coll.gameObject.CompareTag("puerta 2"))
        {
            puertainfo.puertaEntrante = "puerta 2";
            SceneManager.LoadScene("Sala 2");
        }
        else if (coll.gameObject.CompareTag("puerta 4"))
        {
            SceneManager.LoadScene("Sala 4");
        }
        else if (coll.gameObject.CompareTag("puerta 3A"))
        {
            puertainfo.puertaEntrante = "puerta 3A";
            SceneManager.LoadScene("Sala 3 vertical 1");

        }
        else if (coll.gameObject.CompareTag("puerta 5"))
        {
            SceneManager.LoadScene("Sala 5 vertical");
        }
        else if (coll.gameObject.CompareTag("puerta 4F"))
        {
            puertainfo.puertaEntrante = "puerta 4F";
            SceneManager.LoadScene("Sala 4");
        }
        else if (coll.gameObject.CompareTag("Spawn 2"))
        {
            SceneManager.LoadScene("Sala Spawn 1");
        }

        else if (coll.gameObject.CompareTag("puerta 6"))
        {
            SceneManager.LoadScene("Sala 6");
        }
        else if (coll.gameObject.CompareTag("puerta 5A"))
        {
            puertainfo.puertaEntrante = "puerta 5A";
            SceneManager.LoadScene("Sala 5 vertical");
        }
        else if (coll.gameObject.CompareTag("Sala Jefe"))
        {
            SceneManager.LoadScene("Sala Jefe");
        }
        else if (coll.gameObject.CompareTag("Vuelta Spawn 2"))
        {
            SceneManager.LoadScene("Sala Spawn 1");
        }
        else if (coll.gameObject.CompareTag("Puerta 6D"))
        {
            puertainfo.puertaEntrante = "Puerta 6D";
            SceneManager.LoadScene("Sala 6");
        }


        //Mapa 2
        else if (coll.gameObject.CompareTag("Jefe 1 exit"))
        {
            SceneManager.LoadScene("Mapa B1");

        }
        else if (coll.gameObject.CompareTag("Jefe Entry"))
        {
            puertainfo.puertaEntrante = "Puerta jefe 1";
            SceneManager.LoadScene("Sala Jefe");

        }
        else if (coll.gameObject.CompareTag("Puerta B1"))
        {
            SceneManager.LoadScene("Mapa B2");

        }
        else if (coll.gameObject.CompareTag("Puerta RB1"))
        {
            puertainfo.puertaEntrante = "Puerta B1";
            SceneManager.LoadScene("Mapa B1");

        }
        else if (coll.gameObject.CompareTag("Puerta B3"))
        {
            SceneManager.LoadScene("Mapa B3");

        }
        else if (coll.gameObject.CompareTag("Puerta B2D"))
        {
            puertainfo.puertaEntrante = "Puerta B2D";
            SceneManager.LoadScene("Mapa B2");

        }
        else if (coll.gameObject.CompareTag("Puerta B10"))
        {
            SceneManager.LoadScene("Mapa B10");

        }
        else if (coll.gameObject.CompareTag("Puerta B4"))
        {
            SceneManager.LoadScene("Mapa B4");

        }
        else if (coll.gameObject.CompareTag("Puerta B2"))
        {
            puertainfo.puertaEntrante = "Puerta B2";
            SceneManager.LoadScene("Mapa B2");

        }
        else if (coll.gameObject.CompareTag("Puerta B7"))
        {
            SceneManager.LoadScene("Mapa B7");

        }
        else if (coll.gameObject.CompareTag("Puerta B5"))
        {
            SceneManager.LoadScene("Mapa B5");

        }
        else if (coll.gameObject.CompareTag("Puerta B4R"))
        {
            puertainfo.puertaEntrante = "Puerta B4";
            SceneManager.LoadScene("Mapa B4");

        }
        else if (coll.gameObject.CompareTag("Puerta B8"))
        {
            SceneManager.LoadScene("Mapa B8");

        }
        else if (coll.gameObject.CompareTag("Puerta B9"))
        {
            SceneManager.LoadScene("Mapa B9");

        }
        else if (coll.gameObject.CompareTag("Puerta B7I"))
        {
            puertainfo.puertaEntrante = "Puerta B7I";
            SceneManager.LoadScene("Mapa B7");

        }
        else if (coll.gameObject.CompareTag("Puerta B7D"))
        {
            puertainfo.puertaEntrante = "Puerta B7D";
            SceneManager.LoadScene("Mapa B7");

        }
        else if (coll.gameObject.CompareTag("Puerta B3R"))
        {
            puertainfo.puertaEntrante = "Puerta B3R";
            SceneManager.LoadScene("Mapa B3");

        }
        else if (coll.gameObject.CompareTag("Puerta Jefe B"))
        {

            SceneManager.LoadScene("Sala Jefe 1");

        }
        else if (coll.gameObject.CompareTag("Puerta B10R"))
        {
            puertainfo.puertaEntrante = "Puerta B10R";
            SceneManager.LoadScene("Mapa B10");

        }
        else if (coll.gameObject.CompareTag("Puerta B10B"))
        {
            puertainfo.puertaEntrante = "Puerta B10B";
            SceneManager.LoadScene("Mapa B10");

        }
        else if (coll.gameObject.CompareTag("Puerta B12"))
        {
           
            SceneManager.LoadScene("Mapa B12");

        }
        else if (coll.gameObject.CompareTag("Puerta B8R"))
        {
            puertainfo.puertaEntrante = "Puerta B8R";
            SceneManager.LoadScene("Mapa B8");

        }
        else if (coll.gameObject.CompareTag("Puerta B11"))
        {

            SceneManager.LoadScene("Mapa B11");

        }
        else if (coll.gameObject.CompareTag("Puerta Jefe B2"))
        {

            SceneManager.LoadScene("sala Jefe 2");

        }
        else if (coll.gameObject.CompareTag("Sala segura B11"))
        {

            SceneManager.LoadScene("Sala spawn 1");

        }
        else if (coll.gameObject.CompareTag("Puerta B11A"))
        {
            puertainfo.puertaEntrante = "Puerta B11A";
            SceneManager.LoadScene("Mapa B11");

        }
        else if (coll.gameObject.CompareTag("Puerta B11B"))
        {
            puertainfo.puertaEntrante = "Puerta B11B";
            SceneManager.LoadScene("Mapa B11");

        }

    }


}
