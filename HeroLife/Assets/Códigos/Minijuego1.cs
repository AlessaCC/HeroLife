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
    void Start ()
    {
        Nivel1 = new Minijuegos(1, 600, 5);
        Cuerpo = GetComponent<Rigidbody2D>();
        Velocidad = 2;
        Posicion = GetComponent<Transform>();
        derecha = new Vector2(Velocidad, cuerpo.velocity.y);
        izquierda = new Vector2(-Velocidad, cuerpo.velocity.y);
        Nivel1.ExpMaxAtaque = (Nivel1.ExpPorNivel / Nivel1.NumAtaques);
        Debug.Log(Nivel1.ExpMaxAtaque);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Posicion.position.x <= limMin.transform.position.x)
        {
            Cuerpo.velocity = derecha;
        }

        if (Posicion.position.x >= limMax.transform.position.x)
        {
            Cuerpo.velocity = izquierda;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (((Posicion.position.x>0.03f) && (Posicion.position.x <= 0.7f) ) || ((Posicion.position.x < -0.03f) && (Posicion.position.x >= -0.7f)))
            {
                Nivel1.PrecisionAtaque =0.35f;
            }

            if ((Posicion.position.x < -0.7f) || (Posicion.position.x > 0.7f))
            {
                Nivel1.PrecisionAtaque = 0f;
            }
            else
            {
                Nivel1.PrecisionAtaque = 1f;
            }

            Nivel1.Atacar();
        }
    }
        

    

    }





