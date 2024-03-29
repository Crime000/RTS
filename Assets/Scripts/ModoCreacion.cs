using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ModoCreacion : MonoBehaviour
{
    [SerializeField]
    private Camera camara;

    public GUIManager gui;
    public GameObject prefabCubo;
    public GameObject prefabCilindro;
    public GameObject prefabEsfera;
    public TMP_Text Conteo;


    void Update()
    {
        if (gui.creadorActivo)
        {
            Creacion();
        }
    }

    public void Creacion()
    {
        //----------------------------------------------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------------------------------------------

        if (gui.PrefabAInstanciar == 1)
        {
           if (Input.GetMouseButtonDown(0))
           {
              Ray rayoCamara = camara.ScreenPointToRay(Input.mousePosition);
       
              RaycastHit hit;
    
               if(Physics.Raycast(rayoCamara, out hit))
               { 
                    if(hit.collider.gameObject.tag == "Cubo" || hit.collider.gameObject.tag == "Cilindro" || hit.collider.gameObject.tag == "Esfera")
                    {
                        Debug.Log("OCUPADO");
                    }
                    else
                    {
                        Vector3 impacto = new Vector3(hit.point.x, 0.5f, hit.point.z);
                        Instantiate(prefabCubo, impacto, Quaternion.identity);
                        GameObject[] lista = GameObject.FindGameObjectsWithTag("Cubo");
                        Conteo.text = lista.Length.ToString();
                    }
                   
               }
           }
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------------------------------------------

        else if (gui.PrefabAInstanciar == 2)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray rayoCamara = camara.ScreenPointToRay(Input.mousePosition);

                RaycastHit hit;

                if (Physics.Raycast(rayoCamara, out hit))
                {
                    if (hit.collider.gameObject.tag == "Cubo" || hit.collider.gameObject.tag == "Cilindro" || hit.collider.gameObject.tag == "Esfera")
                    {
                        Debug.Log("OCUPADO");
                    }
                    else
                    {
                        Vector3 impacto = new Vector3(hit.point.x, 1f, hit.point.z);
                        Instantiate(prefabCilindro, impacto, Quaternion.identity);
                        GameObject[] lista = GameObject.FindGameObjectsWithTag("Cilindro");
                        Conteo.text = lista.Length.ToString();
                    }

                }
            }
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------------------------------------------

        else if (gui.PrefabAInstanciar == 3)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray rayoCamara = camara.ScreenPointToRay(Input.mousePosition);

                RaycastHit hit;

                if (Physics.Raycast(rayoCamara, out hit))
                {
                    if (hit.collider.gameObject.tag == "Cubo" || hit.collider.gameObject.tag == "Cilindro" || hit.collider.gameObject.tag == "Esfera")
                    {
                        Debug.Log("OCUPADO");
                    }
                    else
                    {
                        Vector3 impacto = new Vector3(hit.point.x, 0.5f, hit.point.z);
                        Instantiate(prefabEsfera, impacto, Quaternion.identity);
                        GameObject[] lista = GameObject.FindGameObjectsWithTag("Esfera");
                        Conteo.text = lista.Length.ToString();
                    }

                }
            }
        }

    }
}
