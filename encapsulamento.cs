using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variaveis : MonoBehaviour
{

    Pai p;
    

    void Start() {


        p = new Pai();
        p.Idade = 9;

        print(p.Idade);
    }


    //UPDATE
    void Update()
    {



    }
}
class Pai : MonoBehaviour
{
    private int idade = 10;

    public int Idade {

        get { return idade; }

        set { if (value > 10) { 
                idade = value; 
            } else { 
                print("Erro!!");
            } }
    
    }


}