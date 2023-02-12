using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linternaScript : MonoBehaviour
{
    public GameObject luz;
    bool estado = false;
    private void Start()
    {
        
    }
    public void toggleLuz()
    {
        if (estado)
        {
            luz.SetActive(false);
            estado = false;
            Debug.Log(estado);
        }
        else
        {
            luz.SetActive(true);
            estado = true;
            Debug.Log(estado);
        }
        
    }

}
