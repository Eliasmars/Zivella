using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void juegar()
    {
        SceneManager.LoadScene("Sala spawn");
    }
    public void menu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Intrucciones()
    {
        SceneManager.LoadScene("controles");
    }
    public void salir()
    {
        Application.Quit();
    }
}
