using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VerEnConsola : MonoBehaviour
{
    public Text numero1;
    public Text numero2;
    public Text Msj;
    public void Input()
    {   
        int num1 = int.Parse(numero1.text);
        int num2 = int.Parse(numero2.text);
        
            if (num2 == 0)
            {
                Debug.Log("El segundo número no debe ser igual a 0, reintentar");
            }
            else if (num1 < 0 || num2 < 0)
            {
                Debug.Log("Los números ingresados no son números enteros, reintentar");
            }
            else if (num1 >= 0 && num2 >= 0)
            {
                int res = num1 / num2;
                Msj.text = res.ToString();
            }
            else 
        //catch(System.FormatException)
            {
            Debug.Log("Hay campos vacíos, reintentar");
            }
        //int counter = 0; counter < int.Parse(cloneAmount.text)
    }

}
