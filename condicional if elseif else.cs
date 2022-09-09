using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variaveis : MonoBehaviour {

    int moedasHeroi = 110;
    int valorVida = 100;

    // Iniciar Alguma coisa
    void Start(){
        if (moedasHeroi == valorVida){
            print("Pode comprar a vida, mas fico zerado de grana.");

        }

        else if(moedasHeroi > valorVida){
            print("Pode comprar a vida e sobra grana!");
        }

        else {
            print("Não pode comprar a vida.");
        }

    }

    // Update is called once per frame
    void Update(){

        
    }
}
