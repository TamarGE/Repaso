using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VerEnConsola : MonoBehaviour
{
    public Text mensaje;
    public Text Msj;
    public void Input()
    {
        if (mensaje.text == "")
        {
            Debug.Log("Mensaje vacío no válido, reintentar");
        }
        else {
            Msj.text = mensaje.text;
        }
    }
    
}
