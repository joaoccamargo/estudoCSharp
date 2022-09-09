using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variaveis : MonoBehaviour {

    //int moedas = 0;
    //float dinheiro = 10.2f;
    //bool duvida = false;
    //string texto = "O melhor RPG do mundo";

    //int carteira = 100;
    //float carteira2 = 10.5f;
    //bool teste = false;
    //string texto;


    //int num1, num2, num3, resultado;

    int prata;

    // Iniciar Alguma coisa
    void Start(){

        //carteira = (int)carteira2; conversão de float para inteiro 
        //carteira = Convert.ToInt32(teste); conversão de bool para int

        //texto = carteira.ToString(); // conversão de int para string 'texto'
        //print(texto);
        //print("O valor de moedas são: " + carteira); // concatenação + valor +

        //num1 = 10;
        //num2 = 20;
        //num3 = 2;

        //resultado = (num2 + num1) * num3;




        //print(carteira++);// Pos Incremento
        //print(carteira);
        //print(++carteira); // Pre Incremento


        prata = 10;

        //prata = prata + 2; //exemplo1
        prata +=2;  // exemplo2 operador reduzido.

        print(prata);
       




    }

    // Update is called once per frame
    void Update(){

        
    }
}
