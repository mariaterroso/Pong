using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{

    public enum WallName { Left, Right }

    [SerializeField]
    ScoreKeeper marcador;

    [SerializeField]
    Ball bola;

    [SerializeField]
    WallName wallName = WallName.Left; 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        /*
         * Quando a bola bater, avisamos o ScoreKeeper 
         * para aumentar a pontuação
         */

        marcador.Goal(wallName);
        bola.Reset();
    }
}
