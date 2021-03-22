using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] float velocidade = 5f;
    bool bolaFoiLancada = false;
    float temporizador = 0.0f;
    float tempoDeEspera = 2.0f;
    bool velocidadeDefinida = false;


    // Start is called before the first frame update
    void Start()
    {
        //if(Random.value < 0.5f)
        //{
        //    GetComponent<Rigidbody2D>().velocity = velocidade * Vector2.right;
        //} else
        //{
        //    GetComponent<Rigidbody2D>().velocity = velocidade * Vector2.left;
        //}

        //lançar a bola
        //GetComponent<Rigidbody2D>().velocity = velocidade * Random.insideUnitCircle;
    }

    // Update is called once per frame - 10 FPS - a cada segundo chama o Update() 10 vezes
    void Update()
    {
        temporizador += Time.deltaTime; // vai buscar a informação de tempo ao Unity Engine

        if (bolaFoiLancada == false)
        {
            GetComponent<Rigidbody2D>().Sleep(); // adormecer/parar a bola

            // verificamos se o temporizador já chegou aos 2 segundos
            if (temporizador > tempoDeEspera)
            {
                bolaFoiLancada = true;

                temporizador -= tempoDeEspera;
            }

        }
        else
        {
            if (velocidadeDefinida == false)
            {
                GetComponent<Rigidbody2D>().velocity = velocidade * Random.insideUnitCircle; // meter a bola a andar
                velocidadeDefinida = true; // só definir a velocidade uma vez
            }
        }
    }
}
