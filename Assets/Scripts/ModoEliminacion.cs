using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModoEliminacion : MonoBehaviour
{

    public GUIManager gui;

    [SerializeField]
    private Camera camara;

    private void Update()
    {
        if (gui.eliminadorActivo)
        {
            ModoEliminar();
        }
    }
    public void ModoEliminar()
    {
        //----------------------------------------------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------------------------------------------

            if (Input.GetMouseButtonDown(0))
            {
                Ray rayoCamara = camara.ScreenPointToRay(Input.mousePosition);

                RaycastHit hit;

                if (Physics.Raycast(rayoCamara, out hit))
                {
                    if (hit.collider.gameObject.tag == "Terreno")
                    {
                        Debug.Log("NO PUEDES ELIMINAR EL TERRENO");
                    }
                    else
                    {
                        Destroy(hit.collider.gameObject);
                    }

                }
            }
    }
}
