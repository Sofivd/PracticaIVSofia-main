using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimpiarCasitas : MonoBehaviour
{
    public void LimpiarlasCasitas()
    {
        Destroy(GameObject.Find("casitaAmarilla(Clone)"));
    }
}
