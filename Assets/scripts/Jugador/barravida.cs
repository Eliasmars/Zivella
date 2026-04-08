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
        barradevida.fillAmount = vidaactual / vidamaxima;

        if (vidaactual <= 0)
        {
            curarCompleto(); 
            SceneManager.LoadScene("Sala spawn");
        }

    }
    public void recibirDaño(float daño)
    {
        vidaactual -= daño;

        if (vidaactual < 0)
            vidaactual = 0;

        actualizarbarra();
        guardarvida();
    }
    public void curarCompleto()
    {
        vidaactual = vidamaxima;
        actualizarbarra();
        guardarvida();
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
