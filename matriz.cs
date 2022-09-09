using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variaveis : MonoBehaviour {

    

    void Start(){


        int[,] matriz = new int[2,2];
        int valor = 1;

        for (int linhas = 0;linhas <= 1; linhas++) {

            for (int colunas = 0; colunas <= 1; colunas++)
            {
                matriz[linhas, colunas] = valor;
                valor++;

            }
        
        }

        for (int linhas = 0; linhas <= 1; linhas++)
        {

            for (int colunas = 0; colunas <= 1; colunas++)
            {
                print(linhas + ":" + colunas + " = " + matriz[linhas, colunas]);

            }

        }




    }

    //UPDATE
    void Update(){

        
    }
}
