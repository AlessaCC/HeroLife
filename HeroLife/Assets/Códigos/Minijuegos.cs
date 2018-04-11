using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minijuegos : MonoBehaviour {
    private int numMinijuego;
    private float expPorNivel;
    private float puntajeObtenido;
    private float porcentajeExito;
    private int numAtaques;
    private float expPorAtaque;
    private string mensaje;
    private bool completado;
    private float precisionAtaque;
    private float expMaxAtaque;

    // Variables, setters y getters
    public float ExpPorNivel
    {
        get
        {
            return expPorNivel;
        }

        set
        {
            expPorNivel = value;
        }
    }

    public float PuntajeObtenido
    {
        get
        {
            return puntajeObtenido;
        }

        set
        {
            puntajeObtenido = value;
        }
    }

    public float PorcentajeExito
    {
        get
        {
            return porcentajeExito;
        }

        set
        {
            porcentajeExito = value;
        }
    }

    public int NumAtaques
    {
        get
        {
            return numAtaques;
        }

        set
        {
            numAtaques = value;
        }
    }

    public string Mensaje
    {
        get
        {
            return mensaje;
        }

        set
        {
            mensaje = value;
        }
    }

    public bool Completado
    {
        get
        {
            return completado;
        }

        set
        {
            completado = value;
        }
    }

    public float ExpPorAtaque
    {
        get
        {
            return expPorAtaque;
        }

        set
        {
            expPorAtaque = value;
        }
    }

    public float PrecisionAtaque
    {
        get
        {
            return precisionAtaque;
        }

        set
        {
            precisionAtaque = value;
        }
    }

    public float ExpMaxAtaque
    {
        get
        {
            return expMaxAtaque;
        }

        set
        {
            expMaxAtaque = value;
        }
    }

    public int NumMinijuego
    {
        get
        {
            return numMinijuego;
        }

        set
        {
            numMinijuego = value;
        }
    }


    // Use this for initialization
    void Start () {
        NumMinijuego = 0;
        ExpPorNivel = 0;
        PuntajeObtenido = 0;
        PorcentajeExito = 0;
        NumAtaques = 0; /* las inicializamos con los valores "" */
        Mensaje = null;
        Completado = false;
        ExpPorAtaque = 0;
        precisionAtaque = 0;
    }

    // Update is called once per frame
    void Update() {
       
        PorcentajeExito = (PuntajeObtenido / ExpPorNivel) * 100;        
	}

    //Cada oportunidad de ataque tendrá un valor diferente dependiendo de la precisión
    public float CalcularExpAtaque ()
    {
        ExpPorAtaque = ExpMaxAtaque * PrecisionAtaque; //precicion ataque es un numero entre 0 y 1
        
        return ExpPorAtaque;
    }

    //Función para sumar el puntaje del minijuego
    public  float SumarPuntaje ()
    {
        if (ExpPorNivel > PuntajeObtenido)
        {
            PuntajeObtenido += ExpPorAtaque;
        }
        return PuntajeObtenido;
    }

    public void Atacar()
    {
        if (NumAtaques > 0)
        {
            CalcularExpAtaque();
            SumarPuntaje();
            NumAtaques -= 1;
        }       
    }

    //Constructor 
    public Minijuegos(int numMinijuego, float expPorNivel, int numAtaques)
    {
        NumMinijuego = numMinijuego;
        ExpPorNivel = expPorNivel;
        NumAtaques = numAtaques;
    }
   

}
