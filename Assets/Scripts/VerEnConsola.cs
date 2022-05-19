using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VerEnConsola : MonoBehaviour
{
    public string mensaje;
    public Text Msj;
    public void Input()
    {
        if (mensaje == "")
        {
            Debug.Log("Mensaje vacío no válido, reintentar");
        }
        else {
            Msj.text = mensaje;
        }
    }
    
}
