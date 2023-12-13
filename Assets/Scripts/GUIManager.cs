using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class GUIManager : MonoBehaviour
{
    public GameObject Menu;
    public GameObject CreacionMenu;


    // Start is called before the first frame update
    void Start()
    {
        CreacionMenu.SetActive(false);
        Menu.SetActive(true);
        Time.timeScale = 0;
    }

    public void Update()
    {
        if (Input.GetKey("escape"))
        {
            EventSystem.current.SetSelectedGameObject(null);
            Menu.SetActive(true);
            Time.timeScale = 0;

        }
    }
    public void Moverse()
    {
        //LeanTween.scale(Menu, Vector3.zero, 1).setEase(LeanTweenType.easeInQuad);
        Time.timeScale = 1;
        Menu.SetActive(false);
    }

    public void Creacion()
    {
        Menu.SetActive(false);
        Time.timeScale = 1;
        CreacionMenu.SetActive(true);
    }

    public void Volver()
    {
        CreacionMenu.SetActive(false);
        Menu.SetActive(true);
        Time.timeScale = 0;
    }

    public void Salir()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
