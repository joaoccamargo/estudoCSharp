using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variaveis : MonoBehaviour
{
    pai p;

    void Start() {

        p = new pai(20);

        print(pai.idade);
      

    }


    //UPDATE
    void Update()
    {



    }
}

class pai
{
    public int idade;
    public pai(int idade) {

        this.idade = idade;

    }




}