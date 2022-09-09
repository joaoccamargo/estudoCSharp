using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variaveis : MonoBehaviour {

    string[] inimigos;
  

    //INICIO

    void Start(){

        inimigos = new string[4];
        inimigos[0] = "caveira";
        inimigos[1] = "matador";
        inimigos[2] = "atirador";
        inimigos[3] = "wark";

        foreach (string nome in inimigos) {
            print(nome);
        
        }


    }

    //UPDATE
    void Update(){

        
    }
}
