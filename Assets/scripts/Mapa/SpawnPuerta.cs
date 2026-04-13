using UnityEngine;

public class Sp : MonoBehaviour
{
    public Transform S2;
    public Transform S3;
    public Transform S4;
    public Transform S5;
    public Transform S6;
    public Transform SJ1;
    public Transform B1;
    public Transform B2;
    public Transform B2D;
    public Transform B4;
    public Transform B7D;
    public Transform B7I;
    public Transform B3R;
    public Transform B10R;
    public Transform B8R;
    public Transform B10B;

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
            case "Puerta jefe 1":
                player.transform.position = SJ1.position;
                break;
            case "Puerta B1":
                player.transform.position = B1.position;
                break;
            case "Puerta B2":
                player.transform.position = B2.position;
                break;
            case "Puerta B2D":
                player.transform.position = B2D.position;
                break;
            case "Puerta B4":
                player.transform.position = B4.position;
                break;
            case "Puerta B7I":
                player.transform.position = B7I.position;
                break;
            case "Puerta B7D":
                player.transform.position = B7D.position;
                break;
            case "Puerta B3R":
                player.transform.position = B3R.position;
                break;
            case "Puerta B10R":
                player.transform.position = B10R.position;
                break;
            case "Puerta B8R":
                player.transform.position = B8R.position;
                break;
            case "Puerta B10B":
                player.transform.position = B10B.position;
                break;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
