using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Minijuego1 : MonoBehaviour
{
    private Minijuegos nivel1; //constructor
    private float velocidad;
    public GameObject limMin;
    public GameObject limMax; // objetos invisibles que se utilizan como límites 
    private Rigidbody2D cuerpo;
    private Transform posicion;
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
    void Start()
    {
        Nivel1 = new Minijuegos(1, 600, 5);
        Cuerpo = GetComponent<Rigidbody2D>();
        Velocidad = 6;
        Posicion = GetComponent<Transform>();
        Nivel1.ExpMaxAtaque = (Nivel1.ExpPorNivel / Nivel1.NumAtaques);
        Debug.Log(Nivel1.ExpMaxAtaque);
    }

    // Update is called once per frame
    void Update()
    {
        if (Posicion.position.x <= limMin.transform.position.x)
        {
            Cuerpo.velocity = new Vector2(Velocidad, cuerpo.velocity.y);
        }

        if (Posicion.position.x >= limMax.transform.position.x)
        {
            Cuerpo.velocity = new Vector2(-Velocidad, cuerpo.velocity.y);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Posicion" + Posicion.position.x);
            if (((Posicion.position.x > 0f) && (Posicion.position.x <= 1.65f)) || ((Posicion.position.x < -0.44f) && (Posicion.position.x >= -2.1f)))
            {
                Nivel1.PrecisionAtaque = 0.5f;
            }
            else if ((Posicion.position.x < -2.1f) || (Posicion.position.x > 1.62f))
            {
                Nivel1.PrecisionAtaque = 0f;
            }
            else
            {
                Nivel1.PrecisionAtaque = 1f;
            }
            Nivel1.Atacar();
            Velocidad += 1.5f;
        }
    }
}