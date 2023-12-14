using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimpiarArMarrones : MonoBehaviour
{
    public void LimpiarArbolesMarrones()
    {
        Destroy(GameObject.Find("arbol2UnityOtoño(Clone)"));
    }
}
