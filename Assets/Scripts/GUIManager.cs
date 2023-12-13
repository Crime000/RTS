using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class GUIManager : MonoBehaviour
{
    public GameObject Menu;
    public GameObject CreacionMenu;
    public GameObject Pulsac;
    public RayoCamara camara;
    public bool creadorActivo = false;
    public float PrefabAInstanciar = 1;


    // Iniciar el Juego con los menús Principales......................................................................................................

    void Start()
    {
        CreacionMenu.SetActive(false);
        Menu.SetActive(true);
        Pulsac.SetActive(false);
        Time.timeScale = 0;
    }

    // Controlador del boton escape y el booleano del modo creación....................................................................................

    public void Update()
    {
        if (Input.GetKey("escape"))
        {
            EventSystem.current.SetSelectedGameObject(null);
            camara.modoRaton = false;
            Menu.SetActive(true);
            Time.timeScale = 0;

        }

        if(creadorActivo == true)
        {
            PulsaC();
        }
    }

    // Opción del Movimiento.............................................................................................................................

    public void Moverse()
    {
        //LeanTween.scale(Menu, Vector3.zero, 1).setEase(LeanTweenType.easeInQuad);
        Time.timeScale = 1;
        Menu.SetActive(false);
        camara.modoRaton = true;
    }

    // Opción del Modo Creación.............................................................................................................................

    public void Creacion()
    {
        Menu.SetActive(false);
        Time.timeScale = 1;
        CreacionMenu.SetActive(true);
    }

    // Opciones de Prefabs.............................................................................................................................

    public void Cubo()
    {
        PrefabAInstanciar = 1;
        CreacionMenu.SetActive(false);
        Pulsac.SetActive(true);
        creadorActivo = true;
    }

    public void Cilindro()
    {
        PrefabAInstanciar = 2;
        CreacionMenu.SetActive(false);
        Pulsac.SetActive(true);
        creadorActivo = true;
    }

    public void Esfera()
    {
        PrefabAInstanciar = 3;
        CreacionMenu.SetActive(false);
        Pulsac.SetActive(true);
        creadorActivo = true;
    }

    // Opción de Volver al modo Selector de Prefabs.............................................................................................................................

    public void PulsaC()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Pulsac.SetActive(false);
            creadorActivo = false;
            CreacionMenu.SetActive(true);
        }
    }

    // Opción de Volver al Menú Principal.............................................................................................................................

    public void Volver()
    {
        CreacionMenu.SetActive(false);
        creadorActivo = false;
        Menu.SetActive(true);
        Time.timeScale = 0;
    }

    // Opción de Salir del Juego.............................................................................................................................

    public void Salir()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
