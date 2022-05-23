using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{
    public float xSpeed;
    public float xRightLimit;
    public float xLeftLimit;
    public bool ToRight;
    public GameObject prefab1;
    public GameObject prefab2;

    void Start()
    {
        ToRight = true;
    }

    void Update()
    {
        if (ToRight)//no hace falta poner ==true.
        {
            transform.position += new Vector3(xSpeed, 0, 0);
        }
        else 
        { 
            transform.position -= new Vector3(xSpeed, 0, 0);
        }
        if (transform.position.x >= xRightLimit)
        {
            ToRight = false;
            Instantiate(prefab1);
        }
        else if (transform.position.x <= xLeftLimit)
        {
            ToRight = true;
            Instantiate(prefab2);
        }

    }
}
