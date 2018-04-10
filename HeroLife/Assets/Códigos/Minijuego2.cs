using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minijuego2 : MonoBehaviour {
    private Minijuegos nivel2;

    public Minijuegos Nivel2
    {
        get
        {
            return nivel2;
        }

        set
        {
            nivel2 = value;
        }
    }

    // Use this for initialization
    void Start () {
        Nivel2 = new Minijuegos(2, 600, 3);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
