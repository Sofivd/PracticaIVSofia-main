using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovCamara : MonoBehaviour
{
    

    static bool CamaraEncendida;
    private bool EstaPulsado;
    public GameObject MenuDeCamara;
    public GameObject InterfazMenu;
    public GameObject CancelarCam;
    void Start()
    {
        
    }
    void Update()
    {
        if (CamaraEncendida == true)
        {
            ParaYaPorfavor();
            InterfazMenu.SetActive(false);
            MenuDeCamara.SetActive(true);
        }
    }
    public void MovimientoCam()
    {
        if(CamaraEncendida == false)
        {
            CamaraEncendida = true;
            
        }
        else
        {
            CamaraEncendida= false;
        }

    }
    public void ParaYaPorfavor()
    {
            if (Input.GetMouseButtonDown(0))
            {
                EstaPulsado = true;
            }
            else if (Input.GetMouseButtonUp(0))
            {
                EstaPulsado = false;
            }
        
        if (EstaPulsado == true)
        {
            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = Input.GetAxis("Mouse Y");

            transform.position = new Vector3(transform.position.x - mouseX, transform.position.y, transform.position.z - mouseY);
            Debug.Log(mouseX + mouseY);
        }
    }

    public void CancelarMenuCam()
    {
        InterfazMenu.SetActive(true);
        MenuDeCamara.SetActive(false);
        EstaPulsado = false;
        CamaraEncendida = false;
    }
}































