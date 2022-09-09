using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variaveis : MonoBehaviour {

    //VETORES/ARRAY

    void Start(){
        //EXEMPLO 1
        /*int[] array = { 1, 2, 3, 4 };
        string[] nome = { "Joao", "Milena", "Nany" };

        print(array[0]);
        print(nome[2]);
        */

        //EXEMPLO2
        //int[] array = new int[4] {4,3,2,1};
        //print(array[3]);

        //EXEMPLO3
        /*
        int[] array = new int[4];
        array[0] = 1;
        array[1] = 2;
        array[2] = 3;
        array[3] = 4;
        */

        //EXEMPLO4
        int[] array = new int[10];

        for (int i = 0; i <= 9; i++) {

            array[i] = i + 1;

            print(i + " : " + array[i]);

        }

        

    }

    //UPDATE
    void Update(){

        
    }
}
