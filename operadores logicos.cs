using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variaveis : MonoBehaviour {

    int numero1 = 10;
    int numero2 = 20;

    // Iniciar Alguma coisa
    void Start(){

        //AND - E
        //quando trabalhamos com and, precisa ter dois valores verdadeiro, se não é falso.
        //numero1 == numero2 FALSO
        //numero1 != numero2 Verdadeiro

        print(numero1 != numero2 && numero1 != numero2); //verdadeiro
        print(numero1 != numero2 && numero1 == numero2); //falso
        print(numero1 == numero2 && numero1 != numero2); //falso
        print(numero1 == numero2 && numero1 == numero2); //falso

        //OR - OU
        //numero1 == numero2 FALSO
        //numero1 != numero2 Verdadeiro
        //quando trabalhamos com OR, se um valor é verdadeiro ele sempre vai ser verdadeiro, somente sendo dois falsos.
        print(numero1 != numero2 || numero1 != numero2); //verdadeiro
        print(numero1 != numero2 || numero1 == numero2); //verdadeiro
        print(numero1 == numero2 || numero1 != numero2); //verdadeiro
        print(numero1 == numero2 || numero1 == numero2); //verdadeiro

        //NOT - NÂO
        //numero1 == numero2 FALSO
        //numero1 != numero2 Verdadeiro
        //Quando trabalhamos com Not ele inverte o valor que recebe.
        print (!(numero1 != numero2));//falso
        print(!(numero1 == numero2));//verdadeiro

    }

    // Update is called once per frame
    void Update(){

        
    }
}
