using UnityEngine;

public class CamaraMovimiento : MonoBehaviour
{

    public Transform objetivo;
    public float veloCamara = 0.025f;
    public Vector3 desplazamiento;

    public void LateUpdate()
    {
        Vector3 posicionDeseada = objetivo.position + desplazamiento;

        Vector3 posicionSuave = Vector3.Lerp(transform.position, posicionDeseada, veloCamara);

        transform.position = posicionSuave;
    }





}
