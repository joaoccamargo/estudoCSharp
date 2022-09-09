using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variaveis : MonoBehaviour {

    

    void Start(){
        List<int> lista = new List<int>();

        for (int i = 0; i <= 9; i++)
        {
            lista.Add(i);        
        }

        foreach (int valores in lista) {
            print(valores);
        }


    }

    //UPDATE
    void Update(){

        
    }
}
