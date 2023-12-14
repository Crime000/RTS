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
    public GameObject ModoEliminar;
    public RayoCamara camara;
    public bool creadorActivo = false;
    public bool eliminadorActivo = false;
    public float PrefabAInstanciar = 1;


    // Iniciar el Juego con los men�s Principales......................................................................................................

    void Start()
    {
        CreacionMenu.SetActive(false);
        ModoEliminar.SetActive(false);
        Menu.SetActive(true);
        Pulsac.SetActive(false);
        Time.timeScale = 0;
    }

    // Controlador del boton escape y el booleano del modo creaci�n....................................................................................

    public void Update()
    {
        if (Input.GetKey("escape"))
        {
            EventSystem.current.SetSelectedGameObject(null);
            CreacionMenu.SetActive(false);
            ModoEliminar.SetActive(false);
            Pulsac.SetActive(false);
            creadorActivo = false;
            eliminadorActivo = false;
            camara.modoRaton = false;
            Menu.SetActive(true);
            Time.timeScale = 0;

        }

        if(creadorActivo == true)
        {
            PulsaC();
        }
    }

    // Opci�n del Movimiento.............................................................................................................................

    public void Moverse()
    {
        //LeanTween.scale(Menu, Vector3.zero, 1).setEase(LeanTweenType.easeInQuad);
        Time.timeScale = 1;
        Menu.SetActive(false);
        camara.modoRaton = true;
    }

    // Opci�n del Modo Creaci�n.............................................................................................................................

    public void Creacion()
    {
        Menu.SetActive(false);
        Time.timeScale = 1;
        CreacionMenu.SetActive(true);
    }

    // Opci�n del Modo Eliminaci�n.............................................................................................................................

    public void Eliminacion()
    {
        Menu.SetActive(false);
        Time.timeScale = 1;
        ModoEliminar.SetActive(true);
        eliminadorActivo = true;
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

    // Opciones de Eliminaciones.............................................................................................................................

    public void EliminarCubo()
    {
        GameObject[] lista = GameObject.FindGameObjectsWithTag("Cubo");
        foreach(var objetos in lista)
        {
            Destroy(objetos);
        }
    }

    public void EliminarCilindro()
    {
        GameObject[] lista = GameObject.FindGameObjectsWithTag("Cilindro");
        foreach (var objetos in lista)
        {
            Destroy(objetos);
        }
    }

    public void EliminarEsfera()
    {
        GameObject[] lista = GameObject.FindGameObjectsWithTag("Esfera");
        foreach (var objetos in lista)
        {
            Destroy(objetos);
        }
    }

    // Opci�n de Volver al modo Selector de Prefabs.............................................................................................................................

    public void PulsaC()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Pulsac.SetActive(false);
            creadorActivo = false;
            CreacionMenu.SetActive(true);
        }
    }

    // Opci�n de Volver al Men� Principal.............................................................................................................................

    public void Volver()
    {
        CreacionMenu.SetActive(false);
        ModoEliminar.SetActive(false);
        creadorActivo = false;
        eliminadorActivo = false;
        Menu.SetActive(true);
        Time.timeScale = 0;
    }

    // Opci�n de Salir del Juego.............................................................................................................................

    public void Salir()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
