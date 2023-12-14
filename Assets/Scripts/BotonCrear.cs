using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BotonCrear : MonoBehaviour
{

    public GameObject MenuCrear;
    public GameObject Interfaz;
    public GameObject arbolVerde;
    public GameObject arbolMarron;
    public GameObject[] Creaciones = new GameObject[4];
    static int BichoSeleccionado = 0;
    public static bool Creacion = false;
    private int objetos;
    public TextMeshProUGUI objetosText;

    private void Start()
    {
        objetos = 0;
    }
    private void Update()
    {
        if(Creacion == true)
        {
            Arbol1();
        }
    }
    public void CrearPulsado()
    {
        if(Creacion == false)
        {
            MenuCrear.gameObject.SetActive(true);
            Interfaz.gameObject.SetActive(false);
            Creacion = true;
        }
        else
        {
            Creacion = false;
            MenuCrear.gameObject.SetActive(false);
            Interfaz.gameObject.SetActive(true);
        }
        
    }
    public void Arbol1()
    {

        if (Input.GetMouseButtonDown(0) && Creacion == true)
        {
           
            Ray rayoCamara = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit crear;
            int mascara = LayerMask.GetMask("Suelo");
            if (Physics.Raycast(rayoCamara, out crear,Mathf.Infinity ,mascara))
            {
                if(crear.collider.gameObject.tag == "Suelo")
                {
                    Debug.Log("Inside");
                    // qUATERNION.IDENTITY -> (0,0,0)
                    GameObject.Instantiate(Creaciones[BichoSeleccionado], crear.point, Creaciones[BichoSeleccionado].transform.rotation);
                    objetos++;
                    Debug.Log(objetos);
                    objetosText.text = "Objetos: " + objetos;
                }
                
            }
        }
    }
    public void ArbolVerde()
    {
        BichoSeleccionado = 0;
    }
    public void ArbolMarron()
    {
        BichoSeleccionado = 1;
    }

    public void Granero()
    {
        BichoSeleccionado = 2;
    }

    public void Casita()
    {
        BichoSeleccionado = 3;
    }
}
