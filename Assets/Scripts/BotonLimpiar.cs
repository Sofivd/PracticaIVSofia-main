using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonLimpiar : MonoBehaviour
{
    public GameObject PanelEliminar;
    
    public void PulsarEliminar()
    {
        PanelEliminar.SetActive(true);

    }

    public void PulsarX()
    {
        PanelEliminar.SetActive(false);
    }
}
