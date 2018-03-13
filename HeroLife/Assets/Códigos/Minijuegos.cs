using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minijuegos : MonoBehaviour {
    private float expPorNivel;
    private float puntajeObtenido;
    private float porcentajeExito;
    private int numAtaques;
    private float expPorAtaque;
    private bool ataqueValido;
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

    public bool AtaqueValido
    {
        get
        {
            return ataqueValido;
        }

        set
        {
            ataqueValido = value;
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


    // Use this for initialization
    void Start () {
        ExpPorNivel = 0;
        PuntajeObtenido = 0;
        PorcentajeExito = 0;
        NumAtaques = 0; /* las inicializamos con los valores "" */
        AtaqueValido = false;
        Mensaje = null;
        Completado = false;
        ExpPorAtaque = 0;
        ExpMaxAtaque = 0;
        precisionAtaque = 0;
	}

    // Update is called once per frame
    void Update() {
        PorcentajeExito = (PuntajeObtenido / ExpPorNivel) * 100;
        
	}

    //Cada oportunidad de ataque tendrá un valor diferente dependiendo de la precisión

    public float CalcularExpAtaque (bool ataqueValido, float expPorAtaque, float expMaxAtaque, float precisionAtaque)
    {
        AtaqueValido = ataqueValido;
        ExpPorAtaque = expPorAtaque;
        PrecisionAtaque = precisionAtaque;
        ExpMaxAtaque = expMaxAtaque;
        if (ataqueValido)
        {
            expPorAtaque = expMaxAtaque * precisionAtaque; //precicion ataque es un numero entre 0 y 1
        }
        return expPorAtaque;
    }

    //Función para sumar el puntaje del minijuego

    public  float SumarPuntaje (float expPorNivel, float puntajeObtenido,  float expPorAtaque)
    {
        ExpPorNivel = expPorNivel;
        PuntajeObtenido = puntajeObtenido;
        ExpPorAtaque = expPorAtaque;
        if (expPorNivel > puntajeObtenido)
        {
            puntajeObtenido += expPorAtaque;
        }
        return puntajeObtenido;
    }
    
   

}
