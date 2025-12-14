using UnityEngine;
using UnityEngine.UI;

public class barravida : MonoBehaviour
{
    public Image barradevida;

    public float vidaactual;

    public float vidamaxima;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        vidaactual = PlayerPrefs.GetFloat("vidajugador", vidamaxima);
        actualizarbarra();
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKey(KeyCode.Space))
        {
            vidaactual -= 2;
            guardarvida();

            actualizarbarra();
        }
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
