using UnityEngine;
using UnityEngine.SceneManagement;

public class Trampa : MonoBehaviour
{
    public barravida barraVida;
    //se explica solo pero, si hace collision con "Player" lo mata, se podria sacar para que tambien mate enemigos
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Sala spawn");
        }
    }
}
