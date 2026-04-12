using UnityEngine;
using UnityEngine.SceneManagement;


public class fogata : MonoBehaviour
{
    public barravida barravida;
    private bool enColisionConHogera1 = false;
    private bool enColisionConHogera2 = false;
    private bool enColisionConHogeraB1 = false;
    private bool enColisionConHogeraB2 = false;
    public static bool Desbloqueadofogata = false;
    public static bool Zona2 = false;
    private void Start()
    {
        
    }
    void Update()
    {
        if (enColisionConHogera1 && Input.GetKeyDown(KeyCode.Space))
        {

            if (Desbloqueadofogata == true)
             {
                 SceneManager.LoadScene("Sala Spawn 1");
            }


        }
        
       
         if (enColisionConHogera2 && Input.GetKeyDown(KeyCode.Space))
        {

            SceneManager.LoadScene("Sala Spawn");

        }
        if (enColisionConHogeraB1 && Input.GetKeyDown(KeyCode.Space))
        {

            SceneManager.LoadScene("Mapa B8");

        }
        if (enColisionConHogeraB2 && Input.GetKeyDown(KeyCode.Space))
        {

            SceneManager.LoadScene("Mapa B1");

        }

        if (enColisionConHogera1 && Input.GetKeyDown(KeyCode.F))
        {



            barravida.curarCompleto();



        }


        if (enColisionConHogera2 && Input.GetKeyDown(KeyCode.F))
        {

            barravida.curarCompleto();

        }
        if (enColisionConHogeraB1 && Input.GetKeyDown(KeyCode.F))
        {

            barravida.curarCompleto();

        }
        if (enColisionConHogeraB2 && Input.GetKeyDown(KeyCode.F))
        {

            barravida.curarCompleto();

        }


    }
    

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("hogera"))
        {
            
            enColisionConHogera1 = true;
        }
        if (coll.gameObject.CompareTag("hogera 2"))
        {
            
            Desbloqueadofogata = true;
            enColisionConHogera2 = true;
        }
        if (coll.gameObject.CompareTag("Fogata B1"))
        {
            Zona2 = true;
            enColisionConHogeraB1 = true;
            Debug.Log("zona 2");
        }
        if (coll.gameObject.CompareTag("Fogata B2"))
        {

            enColisionConHogeraB2 = true;

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
        if (coll.gameObject.CompareTag("Fogata B1"))
        {

            enColisionConHogeraB1 = false;

        }
        if (coll.gameObject.CompareTag("Fogata B2"))
        {

            enColisionConHogeraB2 = false;

        }
    }

}