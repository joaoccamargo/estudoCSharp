using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variaveis : MonoBehaviour
{
    metodos somar;

    void Start() {
        int val;
        int val2;
        somar = new metodos();
        val = somar.soma(10, 2);
        val2 = somar.soma(5, 5);

        print(val);
        print(val2);
    }


    //UPDATE
    void Update()
    {



    }
}

class metodos
{

    public int soma(int valor1, int valor2){
        int resultado = valor1 + valor2;

        return resultado;
    }



}