using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variaveis : MonoBehaviour {

    int valor = 10; // ESCOPO DA CLASSE, VARIAVEL DECLARADA, PODE SER USADA EM AMBOS
    //SE FOR USAR A VARIAVEL SOMENTE UMA VEZ, NÃO TEM NECESSIDADE DE USAR DENTRO DA CLASSE.

    void Start() {
        int valor2 = 20;
        print(valor2);
        
                
    }

    //UPDATE
    void Update(){
        print(valor);


    }
}
