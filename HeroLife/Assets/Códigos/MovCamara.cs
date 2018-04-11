using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovCamara : MonoBehaviour {
    private float velocidad;
    private int ancho;
    private int limite;

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

    public int Ancho
    {
        get
        {
            return ancho;
        }

        set
        {
            ancho = value;
        }
    }

    public int Limite
    {
        get
        {
            return limite;
        }

        set
        {
            limite = value;
        }
    }

    // Use this for initialization
    void Start () {
        Velocidad = 20f;
        Ancho = Screen.width;
        Limite = 1;
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetMouseButton(1) && (transform.position.x <=-0.03f) && (transform.position.x >= -16.4f))
        {
            if (Input.GetAxis("Mouse X") > 0)
            {
                transform.position+= new Vector3(Input.GetAxisRaw("Mouse X")*Time.deltaTime * velocidad, 0f, 0f);
            }
            else if(Input.GetAxis("Mouse X") < 0)
            {
                transform.position+= new Vector3(Input.GetAxisRaw("Mouse X") * Time.deltaTime * velocidad, 0f, 0f);
            }
        }

        if (transform.position.x <-16.4)
        {
            transform.position = new Vector3(transform.position.x +0.5f,transform.position.y, transform.position.z);
        }
        if (transform.position.x >-0.3)
        {
            transform.position = new Vector3(transform.position.x-0.5f,transform.position.y, transform.position.z);
        }
    }
}
