using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField]
    float velocidade = 0.5f;

    [SerializeField]
    float paddleHeight = 1f;

    [SerializeField]
    KeyCode upKey = KeyCode.UpArrow;

    [SerializeField]
    KeyCode downKey = KeyCode.DownArrow;
    
    // Update is called once per frame
    void Update()
    {
        /**
         * se tecla para cima premida
         * então subir
         * senão se tecla para baixo premida
         * então descer
         */


        /*
         * Mover a raquete
         */
        if(Input.GetKey(upKey))
        {
            //transform.position =
            //    transform.position + velocidade * Vector3.up;

            transform.position += velocidade * Vector3.up * Time.deltaTime;

        }
        else if (Input.GetKey(downKey))
        {
            //transform.position =
            //    transform.position + velocidade * Vector3.down;
            transform.position += velocidade * Vector3.down * Time.deltaTime;
        }


        /*
         * Verificar os limites (com ifs)
         */

        //float cameraHeight = Camera.main.orthographicSize;

        //if(transform.position.y >= cameraHeight - 0.5f)
        //{
        //    //Variável auxiliar para poder alterar o valor de .y no transform.position
        //    Vector3 positionAux = transform.position;
        //    positionAux.y = cameraHeight - 0.5f;
        //    transform.position = positionAux;
        //}
        //if(transform.position.y <= -cameraHeight + 0.5f)
        //{
        //    Vector3 positionAux = transform.position;
        //    positionAux.y = -cameraHeight + 0.5f;
        //    transform.position = positionAux;
        //}


        /*
         * Verificar os limites (Clamp)
         */

        float cameraHeight = Camera.main.orthographicSize;
        Vector3 positionAux = transform.position;
        positionAux.y = Mathf.Clamp(positionAux.y,
            -cameraHeight + (paddleHeight * 0.5f),
            cameraHeight - (paddleHeight * 0.5f)); ;
        transform.position = positionAux;


    }
}
