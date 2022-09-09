using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variaveis : MonoBehaviour {

    

    void Start(){


        Dictionary<string, string> monstro = new Dictionary<string, string> ();

        monstro.Add("Gosma", "Smilee Smilee");
        monstro.Add("Esqueleto", "Ossos rangendo");

        monstro.Remove("Gosma");

        foreach (string id in monstro.Keys) {

           

                print(monstro[id]);
         
        }
    }

    //UPDATE
    void Update(){

        
    }
}
