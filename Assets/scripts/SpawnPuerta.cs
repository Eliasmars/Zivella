using UnityEngine;

public class Sp : MonoBehaviour
{
    public Transform S2;
    public Transform S3;
    public Transform S4;
    public Transform S5;
    public Transform S6;
    void Start()
    {
        GameObject player = GameObject.FindWithTag("Player");
        switch (puertainfo.puertaEntrante)
        {
            

            case "puerta 2":
                player.transform.position = S2.position;
                break;
            case "puerta 3A":
                player.transform.position = S3.position;
                break;
            case "puerta 4F":
                player.transform.position = S4.position;
                break;
            case "puerta 5A":
                player.transform.position = S5.position;
                break;
            case "Puerta 6D":
                player.transform.position = S6.position;
                break;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
