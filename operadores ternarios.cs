using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variaveis : MonoBehaviour {

    int moedasHeroi = 120;
    int valorVida = 100;
    string result;

    //INICIO

    void Start(){
        /*if (moedasHeroi >= valorVida){
            print("Pode comprar a vida");

        }
        else {
            print("Não tem moedas suficiente.");
        }*/
        //CONDIÇÃO?TRUE:FALSE

        result = (moedasHeroi >= valorVida) ? "Pode comprar a vida" : "Não tem moedas suficiente";
        print(result);


    }

    //UPDATE
    void Update(){

        
    }
}
