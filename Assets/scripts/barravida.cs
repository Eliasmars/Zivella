using UnityEngine;
using UnityEngine.UI;

public class barravida : MonoBehaviour
{
    public Image barradevida;

    public float vidaactual;

    public float vidamaxima;

    public float vidaBase = 100; //Base de vida para cuando se mejora la vida, aumente esto 


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        vidaBase = vidaactual;
        vidaactual = PlayerPrefs.GetFloat("vidajugador", vidamaxima);
        actualizarbarra();
    }

    // Update is called once per frame

    public void Daño(int cantidad) //formula de daño, recibe el daño de los enemigos con "Cantidad" y si esta llega a 0, destrulle el jugador
    {
        vidaactual -= cantidad;
        if (vidaactual < 0)
        {
            Destroy(gameObject);
        }
    }

    void Update() //intento de bajar la bara de vida visual
    {
        barradevida.fillAmount = vidaactual;


    }

    public void actualizarbarra()
    {
        barradevida.fillAmount = vidaactual / vidamaxima;
    }
    public void guardarvida()
    {
        PlayerPrefs.SetFloat("vidajugador", vidaactual);
        PlayerPrefs.Save();
    }

}
