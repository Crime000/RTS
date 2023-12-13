using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayoCamara : MonoBehaviour
{
    //Para la camara en modo ratón-----------------------------------
    //---------------------------------------------------------------

    [SerializeField]
    private Camera cam;
    private Vector3 OrigenMovimiento;
    public bool modoRaton = false;

    //Para la camara en modo normal-----------------------------------
    //----------------------------------------------------------------

    private Vector3 NuevaPosicion;
    public float velocidadNormal;
    public float velocidadRapida;
    public float velocidad;
    public float tiempo;

    // Update is called once per frame
    void Update()
    {
        if(modoRaton == true)
        {
            PanCamara();
        }
        else
        {
            MovCamara();
        }
    }

    void PanCamara()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 correccionEjes = new Vector3(Input.mousePosition.x, 0.0f, Input.mousePosition.y);
            OrigenMovimiento = correccionEjes;
        }
        else if (Input.GetMouseButton(0))
        {
            Vector3 correccionEjes = new Vector3(Input.mousePosition.x, 0.0f, Input.mousePosition.y);
            Vector3 Distancia = OrigenMovimiento - correccionEjes;

            Debug.Log(OrigenMovimiento + "OrigenMovimiento" + Input.mousePosition + "posicion raton" + Distancia);
            
            transform.position += Distancia * Time.deltaTime;
        }
    }

    void MovCamara()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            velocidad = velocidadRapida;
        }
        else
        {
            velocidad = velocidadNormal;
        }


        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            NuevaPosicion += transform.forward * velocidad;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            NuevaPosicion += transform.right * -velocidad;
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            NuevaPosicion += transform.forward * -velocidad;
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            NuevaPosicion += transform.right * velocidad;
        }

        transform.position = Vector3.Lerp(transform.position, NuevaPosicion, Time.deltaTime * tiempo);
    }

    //*
    // if (Input.GetMouseButtonDown(0))
    //    {
    //       Ray rayoCamara = Camera.main.ScreenPointToRay(Input.mousePosition);
    //   
    //       RaycastHit hit;
    //
    //        if(Physics.Raycast(rayoCamara, out hit) && hit.collider.gameObject.tag == "Enemigo")
    //        {
    //            Destroy(hit.collider.gameObject, 1f);
    //        }
    //    }

}
