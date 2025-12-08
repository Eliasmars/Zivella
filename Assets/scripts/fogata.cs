using UnityEngine;
using UnityEngine.SceneManagement;


public class fogata : MonoBehaviour
{
    private bool enColisionConHogera1 = false;
    private bool enColisionConHogera2 = false;
    public static bool Desbloqueadofogata = false;

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
       


    }
    

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("hogera"))
        {
            
            enColisionConHogera1 = true;
        }
        if (coll.gameObject.CompareTag("hogera 2"))
        {
            Debug.Log("Entré en hogera 2");
            Desbloqueadofogata = true;
            enColisionConHogera2 = true;
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
        
    }

}