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
        int num = int.Parse(mensaje.text);
        if (num < 0)
        {
            Debug.Log("Número que no es entero no es válido, reintentar");
        }
        else {
            int res = num * num;
            Msj.text = res.ToString();
        }
        //int counter = 0; counter < int.Parse(cloneAmount.text)
    }

}
