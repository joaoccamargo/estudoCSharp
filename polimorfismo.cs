using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variaveis : MonoBehaviour
{

    guerreiro wr;
    mago mg;
   

    void Start() {

        wr = new guerreiro();
        mg = new mago();

        wr.desc();
        mg.desc();

       
    }


    //UPDATE
    void Update()
    {



    }
}

class classes : MonoBehaviour
{

    public virtual void desc()
    {
        print("os pontos de vida e igual para todos.");
    }


}

class guerreiro : classes {

    public override void desc()
    {
        print("os pontos de vida do guerreiro e maior");

    }

}

class mago : classes{
    public override void desc()
    {
        print("os pontos de vida do mago e menor");

    }
}