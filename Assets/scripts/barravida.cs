using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class barravida : MonoBehaviour
{
    public Image barradevida;

    public float vidaactual;

    public float vidamaxima;

     //Base de vida para cuando se mejora la vida, aumente esto 


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        vidaactual = PlayerPrefs.GetFloat("vidajugador", vidamaxima);
        actualizarbarra();
    }

    // Update is called once per frame

    

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
