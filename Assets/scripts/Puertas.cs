using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEditor.Searcher.SearcherWindow.Alignment;
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
        if (coll.gameObject.CompareTag("Puerta inicial"))
        {
            SceneManager.LoadScene("Sala 2");
        } else if (coll.gameObject.CompareTag("Puerta spawn"))
        {
            SceneManager.LoadScene("Sala spawn");
        }
        else if (coll.gameObject.CompareTag("puerta 3"))
        {
            SceneManager.LoadScene("Sala 3 vertical 1");
        }
        else if (coll.gameObject.CompareTag("puerta 2"))
        {
            SceneManager.LoadScene("Sala 2");
        }
        else if (coll.gameObject.CompareTag("puerta 4"))
        {
            SceneManager.LoadScene("Sala 4");
        }
        else if (coll.gameObject.CompareTag("puerta 3A"))
        {
            SceneManager.LoadScene("Sala 3 vertical 1");

        }
        else if (coll.gameObject.CompareTag("puerta 5"))
        {
            SceneManager.LoadScene("Sala 5 vertical");
        }
        else if (coll.gameObject.CompareTag("puerta 4F"))
        {
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
            SceneManager.LoadScene("Sala 6");
        }


    }

   
}
