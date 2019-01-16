using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S07A38 : MonoBehaviour {

    public string[] fruta;

	// Use this for initialization
	void Start () {

        print(fruta[2]);

        print("O comprimento da array fruta é:" + fruta.Length);

        for(int elemento = 0; elemento < fruta.Length; elemento++) {
            print("O nome da fruta é:" + fruta[elemento]);
        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
