using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonEliminar : MonoBehaviour
{
    
    void Start()
    {
        int mascara = LayerMask.GetMask("Suelo");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PulsarEliminar()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray rayoCamara = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit golpe;
            if (Physics.Raycast(rayoCamara, out golpe))
            {
                Destroy(golpe.collider.gameObject);
            }
        }
    }
}
