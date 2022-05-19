using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnPorInspector : MonoBehaviour
{
    public string mensaje;
    public Text Msj;  
    public void Mostrar()
    {
        Msj.text = mensaje; 
    }
}
