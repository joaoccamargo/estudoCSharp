using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variaveis : MonoBehaviour{

    Guerreiro humanoFase1;
    Guerreiro humanoFase2;


    void Start()
    {
        humanoFase1 = new Guerreiro();
        humanoFase2 = new Guerreiro();


    }

    //UPDATE
    void Update()
    {



    }
}

class Guerreiro
{
    //Caracteristicas//Atributos

    string raca;
    string arma;
    int forca;

    //A��es//Metodos

    void atacar()
    {

    }


}