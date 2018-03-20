using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Minijuego1 : MonoBehaviour {

    private Minijuegos nivel1; //constructor
    private float velocidad;
    public GameObject limMin;
    public GameObject limMax; // objetos invisibles que se utilizan como límites 
    private Rigidbody2D cuerpo;
    private Transform posicion;
    private Vector2 derecha;
    private Vector2 izquierda;  //vectores que se utilizan para mover la bolita
    private bool ataque;
    


    public Minijuegos Nivel1
    {
        get
        {
            return nivel1;
        }

        set
        {
            nivel1 = value;
        }
    }  

    public Rigidbody2D Cuerpo
    {
        get
        {
            return cuerpo;
        }

        set
        {
            cuerpo = value;
        }
    }

    public Transform Posicion
    {
        get
        {
            return posicion;
        }

        set
        {
            posicion = value;
        }
    }

    public Vector2 Derecha
    {
        get
        {
            return derecha;
        }

        set
        {
            derecha = value;
        }
    }

    public Vector2 Izquierda
    {
        get
        {
            return izquierda;
        }

        set
        {
            izquierda = value;
        }
    }

    public bool Ataque
    {
        get
        {
            return ataque;
        }

        set
        {
            ataque = value;
        }
    }

    public float Velocidad
    {
        get
        {
            return velocidad;
        }

        set
        {
            velocidad = value;
        }
    }





    // Use this for initialization
    void Start () {
        Nivel1 = new Minijuegos(1, 600, 3);
        Cuerpo = GetComponent<Rigidbody2D>();
        Velocidad = 3;
        Posicion = GetComponent<Transform>();
        derecha = new Vector2(Velocidad, cuerpo.velocity.y);
        izquierda = new Vector2(-Velocidad, cuerpo.velocity.y);
        
    }

    // Update is called once per frame
    void Update() {
        if (Posicion.position.x<=limMin.transform.position.x)
        {
            Cuerpo.velocity = derecha;
        }

        if (Posicion.position.x>= limMax.transform.position.x)
        {
            Cuerpo.velocity = izquierda;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Atacar();
        }
        

    }

    public void Atacar()
    {
        if (Nivel1.NumAtaques > 0)
        {
            if (posicion.position.x>=-0.092f && posicion.position.x <=0.092f )
            {
                Nivel1.PrecisionAtaque = 1F;
            }

            if (posicion.position.x >= -0.206f && posicion.position.x <= 0.206f)
            {
                Nivel1.PrecisionAtaque = 2/3 ;
            }

            else
            {
                Nivel1.PrecisionAtaque = 0;
            }
            Debug.Log(nivel1.PrecisionAtaque);

            Nivel1.CalcularExpAtaque();
            Debug.Log(Nivel1.ExpPorAtaque);
            Nivel1.SumarPuntaje();

            Velocidad += Mathf.Log(2, Velocidad);

            Nivel1.NumAtaques -= 1;
        }
        
        Debug.Log(Nivel1.PuntajeObtenido);
    }
}
