using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Visible : MonoBehaviour
{
    public GameObject myObject;
   public void Ver()
    {
        myObject.SetActive(!myObject.activeInHierarchy);
    }
}  
