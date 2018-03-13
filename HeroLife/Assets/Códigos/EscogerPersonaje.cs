using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EscogerPersonaje : MonoBehaviour
{
    Image mPersonaje;
    public Sprite mujer;
    public Sprite hombre;

    // Use this for initialization
    void Start()
    {
        mPersonaje = GetComponent<Image>();
    }

    public void CambiarSpriteAMujer()
    {
        mPersonaje.sprite = mujer;
    }

    public void CambiarSpriteAHombre()
    {
        mPersonaje.sprite = hombre;
    }

}
