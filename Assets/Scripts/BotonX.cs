using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonX : MonoBehaviour
{
    public GameObject MenuCrear;
    public GameObject Interfaz;
    
    public void CerrarMenuCrear()
    {
        MenuCrear.gameObject.SetActive(false);
        Interfaz.gameObject.SetActive(true);
        BotonCrear.Creacion = false;
    }
   
}
