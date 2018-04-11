using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PopUps : MonoBehaviour {
    private Ray rayo;
    private RaycastHit choca;
    private GameObject m2;
    private float puntos1;

    public Ray Rayo
    {
        get
        {
            return rayo;
        }

        set
        {
            rayo = value;
        }
    }

    public RaycastHit Choca
    {
        get
        {
            return choca;
        }

        set
        {
            choca = value;
        }
    }

    public GameObject M2
    {
        get
        {
            return m2;
        }

        set
        {
            m2 = value;
        }
    }

    public float Puntos1
    {
        get
        {
            return puntos1;
        }

        set
        {
            puntos1 = value;
        }
    }

    // Use this for initialization
    void Start () {
        M2 = GameObject.FindGameObjectWithTag("M2");
        M2.SetActive(false);
        Puntos1 = GameObject.Find("Punto").GetComponent<Minijuego1>().Nivel1.PuntajeObtenido;
	}
	
	// Update is called once per frame
	void Update () {
        Rayo = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (puntos1 >= 300)
        {
            M2.SetActive(true);
        }

        if (Physics.Raycast(rayo, out choca)&&(Input.GetMouseButton(0)))
        {
            if(choca.collider.name == "M1")
            {
                SceneManager.LoadScene(4);
            }
            if (choca.collider.name== "M2")
            {
                SceneManager.LoadScene(5);
            }
        }
    }


}
