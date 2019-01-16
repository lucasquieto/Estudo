using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S07A37 : MonoBehaviour {

    public string[] fruta;
    private int elemento;

	// Use this for initialization
	void Start () {

        print(fruta[2]);

        print("O comprimento da array fruta é:" + fruta.Length);

        elemento = 0;

        while( elemento < fruta.Length ) {
            print(fruta[elemento]);
            elemento++;
        }


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
