using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S07A32 : MonoBehaviour {

    int velocidade = 100;
    int distancia = 100;
    int tempo = 10;

    int resultado = 0;

    //  +=  -=  *=  /=  %/

	// Use this for initialization
	void Start () {

        //distancia += tempo;
        //print(distancia);

        //  =  -  *  /  %

        resultado = distancia + tempo;
        print(resultado);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
