using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S07A35 : MonoBehaviour {

    int vida = 3;
    int forca = 10;

	// Use this for initialization
	void Start () {
		
        // &&   and
        // ||   or
        // !    não - inverte o sinal

        if(vida >= 1 && forca == 10) {
            print("condição verdadeira!");
        }
        else {
            print("condição falsa!");
        }



	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
