using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variaveis : MonoBehaviour
{
   

    void Start() {

        int retorno = metodos.soma(2, 2);

        print(retorno);

    }


    //UPDATE
    void Update()
    {



    }
}

class metodos
{
    public static int soma(int valor1, int valor2) {

        int result = valor1 + valor2;

        return result;
    
    }    




}