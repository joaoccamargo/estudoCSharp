using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variaveis : MonoBehaviour
{
    metodos obj;

    void Start() {

        obj = new metodos(20,"Player");

        print(obj.valor1);
        print(obj.valor2);

    }


    //UPDATE
    void Update()
    {



    }
}

class metodos
{
    public int valor1;
    public string valor2;
    
    public metodos(int valor, string val)
    {
        this.valor1 = valor;
        this.valor2 = val;
    }

    



}