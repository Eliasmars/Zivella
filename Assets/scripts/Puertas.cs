using UnityEngine;
using UnityEngine.SceneManagement;
public class Puertas : MonoBehaviour
{
    private bool enColisionPuerta = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enColisionPuerta && Input.GetKeyDown(KeyCode.Space))
        {

        }
    }
    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("hogera"))
        {

            enColisionPuerta = true;
        }
    }

    private void OnCollisionExit2D(Collision2D coll)
    {

        if (coll.gameObject.CompareTag("hogera"))
        {

            enColisionPuerta = false;
        }
    }
}
