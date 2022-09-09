using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variaveis : MonoBehaviour
{
    

    void Start() {
       
    }


    //UPDATE
    void Update()
    {



    }
}

class pai{

    public int idade;


}

class filho : pai {
    public void pegaIdade() {

        base.idade;
        
    
    }

}