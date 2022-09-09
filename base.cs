using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variaveis : MonoBehaviour
{
    pai p;
    filho f;

    void Start() {

        p = new pai();
        f = new filho();

        f.pegaIdade();

    }


    //UPDATE
    void Update()
    {



    }
}

class pai : MonoBehaviour
{
    public int idade = 50;




}

class filho : pai
{

    public void pegaIdade() {
        print(base.idade);
    
    }

}