using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimpiarGraneros : MonoBehaviour
{
    public void LimpiarlosGraneros()
    {
        Destroy(GameObject.Find("GraneroChachi(Clone)"));
    }
}
