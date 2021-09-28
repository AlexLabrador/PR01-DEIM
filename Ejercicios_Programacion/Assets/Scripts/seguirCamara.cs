using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seguirCamara : MonoBehaviour
{
    //variable tipo transform asociada al jugador
    [SerializeField] Transform playerPosition;

    //variables para el movimiento de la camara
    [SerializeField] float distanciaJugador = 2f;
    [SerializeField] float alturaCamara = 1.5f;

    Vector3 cameraPosition;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(playerPosition);
        cameraPosition = new Vector3(0f, playerPosition.position.y + alturaCamara, playerPosition.position.z - distanciaJugador);
        transform.position = cameraPosition;
    }
}
