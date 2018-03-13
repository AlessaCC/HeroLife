using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;




public class ControlMenu : MonoBehaviour {

    GameObject panel;
    

    public void Start()
    {      
        panel = GameObject.FindGameObjectWithTag("Opciones");
        panel.SetActive(false);
        
    }

    // Use this for initialization
    public void NuevoJuego()
    {
        SceneManager.LoadScene(1);
    }

    public void Salir()
    {
        Application.Quit(); 
    }

    public void ElMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Creditos()
    {
        SceneManager.LoadScene(2);
    }

    public void Jugar()
    {
        SceneManager.LoadScene(3);
    }

    public void Panel()
    {
      
        if (panel.activeSelf==false)
        {
            panel.SetActive(true);
        }
        else
        {
            panel.SetActive(false);
        }
    }


}
