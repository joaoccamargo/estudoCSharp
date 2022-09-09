using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variaveis : MonoBehaviour {

    //Estado = 1 - Coragem
    //Estado = 2 - Meio Termo
    //Estado = 3 - Covardia

    int estados = 4;


    //INICIO

    void Start(){

        /*
        if (estados == 1)
        {
            print("Mate o heroi");
        }
        else if (estados == 2)
        {
            print("Mate se puder");
        }
        else if (estados == 3)
        {
            print("Corra agora!");
        }
        else {
            print("Nenhum estado selecionado.");
        }*/

        switch (estados) {
            case 1 :
                print("Mate o heroi");
                break;
            case 2:
                print("Mate se puder");
                break;
            case 3:
                print("Corra agora!");
                break;
            default:
                print("Nenhum estado selecionado.");
                break;


        }

    }

    //UPDATE
    void Update(){

        
    }
}
