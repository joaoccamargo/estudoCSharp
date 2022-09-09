using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variaveis : MonoBehaviour
{
    //public
    Guerreiro humanoFase1;
    Guerreiro humanoFase2;
    filha fi;


    void Start()
    {
        humanoFase1 = new Guerreiro();
        humanoFase2 = new Guerreiro();
        fi = new filha();

        ///humanoFase1.nome = "Warrior";
        humanoFase1.arma = "Espada de Ferro";
        humanoFase1.dano = 5;

        //humanoFase2.nome = "WRzin";
        humanoFase2.arma = "Espada do Dragão";
        humanoFase2.dano = 100;

        fi.acessa();

    }

    //UPDATE
    void Update()
    {



    }
}

class Guerreiro : MonoBehaviour
{
    //Caracteristicas//Atributos
    protected string nome;
    public string arma;
    public int dano;

    //Ações//Metodos

    void atacar()
    {

    }


}

class filha : Guerreiro {

    public void acessa() {
       print(nome = "WR");
    }



}