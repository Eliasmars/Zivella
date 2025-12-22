using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class ataque : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.V))
        {
            StartCoroutine(Esperar());

        } 
    }
    IEnumerator Esperar()
    {
        Vector3 escala = transform.localScale;
        escala.x = 0.5f;
        transform.localScale = escala;
        transform.rotation = Quaternion.Euler(0, 0, 10);
        yield return new WaitForSeconds(0.01f);
        Debug.Log("Pasaron 2 segundos");
        transform.rotation = Quaternion.Euler(0, 0, 0);
        yield return new WaitForSeconds(0.01f);
        Debug.Log("Pasaron 2 segundos");
        transform.rotation = Quaternion.Euler(0, 0, -10);
        yield return new WaitForSeconds(0.01f);
        Debug.Log("Pasaron 2 segundos");
        transform.rotation = Quaternion.Euler(0, 0, -20);
        yield return new WaitForSeconds(0.01f);
        Debug.Log("Pasaron 2 segundos");
        transform.rotation = Quaternion.Euler(0, 0, -30);
        yield return new WaitForSeconds(0.01f);
        Debug.Log("Pasaron 2 segundos");
        transform.rotation = Quaternion.Euler(0, 0, -40);
        yield return new WaitForSeconds(0.01f);
        Debug.Log("Pasaron 2 segundos");
        transform.rotation = Quaternion.Euler(0, 0, -50);
        yield return new WaitForSeconds(0.01f);
        Debug.Log("Pasaron 2 segundos");
        transform.rotation = Quaternion.Euler(0, 0, -60);
        yield return new WaitForSeconds(0.01f);
        Debug.Log("Pasaron 2 segundos");
        transform.rotation = Quaternion.Euler(0, 0, -70);
        yield return new WaitForSeconds(0.01f);
        Debug.Log("Pasaron 2 segundos");
        transform.rotation = Quaternion.Euler(0, 0, -80);
        yield return new WaitForSeconds(0.01f);
        Debug.Log("Pasaron 2 segundos");
        transform.rotation = Quaternion.Euler(0, 0, -90);
        yield return new WaitForSeconds(0.01f);
        Debug.Log("Pasaron 2 segundos");
        transform.rotation = Quaternion.Euler(0, 0, -100);
        yield return new WaitForSeconds(0.01f);
        Debug.Log("Pasaron 2 segundos");
        transform.rotation = Quaternion.Euler(0, 0, -110);
        yield return new WaitForSeconds(0.01f);
        Debug.Log("Pasaron 2 segundos");
        transform.rotation = Quaternion.Euler(0, 0, -120);
        yield return new WaitForSeconds(0.01f);
        Debug.Log("Pasaron 2 segundos");
        transform.rotation = Quaternion.Euler(0, 0, -130);
        yield return new WaitForSeconds(0.01f);
        Debug.Log("Pasaron 2 segundos");
        transform.rotation = Quaternion.Euler(0, 0, -140);
        yield return new WaitForSeconds(0.01f);
        Debug.Log("Pasaron 2 segundos");
        transform.rotation = Quaternion.Euler(0, 0, -150);
        yield return new WaitForSeconds(0.01f);
        Debug.Log("Pasaron 2 segundos");
        transform.rotation = Quaternion.Euler(0, 0, -160);
        yield return new WaitForSeconds(0.01f);
        Debug.Log("Pasaron 2 segundos");
        transform.rotation = Quaternion.Euler(0, 0, -170);
        yield return new WaitForSeconds(0.01f);
        Debug.Log("Pasaron 2 segundos");
        transform.rotation = Quaternion.Euler(0, 0, -180);
        yield return new WaitForSeconds(0.01f);
        Debug.Log("Pasaron 2 segundos");
        transform.rotation = Quaternion.Euler(0, 0, -190);
        yield return new WaitForSeconds(0.01f);
        Debug.Log("Pasaron 2 segundos");
        Vector3 escala2 = transform.localScale;
        escala.x = 0.05f;
        transform.localScale = escala;
    }   

}
