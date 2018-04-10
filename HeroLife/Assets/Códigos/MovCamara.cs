using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovCamara : MonoBehaviour {
    private float velocidad;
    private Vector3 posicion;

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

    public Vector3 Posicion
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



    // Use this for initialization
    void Start () {
        Velocidad = 0.3f;
        Posicion = GetComponent<Transform>().position;
        
    }
	
	// Update is called once per frame
	void Update () {
        float xAxis = Input.GetAxis("Horizontal") * velocidad;
        posicion.x = Mathf.Clamp(transform.position.x, -16.45f, -0.04f);
        posicion = new Vector3(transform.position.x + xAxis, transform.position.y, transform.position.z);
    }
}
