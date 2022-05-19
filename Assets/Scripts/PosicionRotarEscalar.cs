using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosicionRotarEscalar : MonoBehaviour
{
    public GameObject myCube;
    public GameObject rotado;
    public GameObject escalado;
    public GameObject rotadoyEscalado;
    public Vector3 originalRotation;
    public Vector3 originalScale;
    public bool isRotated;


    void Start()
    {
        isRotated = false;
        originalRotation = myCube.transform.eulerAngles;
        originalScale = myCube.transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (isRotated)
            {
                myCube.transform.eulerAngles = originalRotation;
                isRotated = false;
            }
            else
            {
                myCube.transform.eulerAngles = rotado.transform.eulerAngles;
                isRotated = true;
            }
        }
    }
}
