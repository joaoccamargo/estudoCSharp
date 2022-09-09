using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//ENUM OTIMO PARA TRABALHAR COM INTELIGENCIA ARTIFICIAL
public class variaveis : MonoBehaviour {

    enum AI {Atacar, Correr, Patrulhar}

    void Start(){

        AI monstrofase1 = AI.Patrulhar;

        AI monstrofase2 = AI.Atacar;

        AI monstrofase3 = AI.Correr;

        int m1 = (int)monstrofase1;

        print(m1);

        
    }

    //UPDATE
    void Update(){

        
    }
}
