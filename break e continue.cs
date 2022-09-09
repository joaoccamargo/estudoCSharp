using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variaveis : MonoBehaviour {

    string[] inimigos;
    int x = 0;
  

    //INICIO

    void Start(){

        //Laço for

        for (int i = 0; i <= 10; i++)
        {
            print(i);
            if (i == 5) {
                break;
            }
        }

        //Laço Foreach

        inimigos = new string[4];
        inimigos[0] = "caveira";
        inimigos[1] = "matador";
        inimigos[2] = "atirador";
        inimigos[3] = "wark";

        foreach (string nome in inimigos) {
            print(nome);
            if (nome == "matador") {
                continue;
            }
            print(nome);
        }


    }

    //UPDATE
    void Update(){

        
    }
}
