using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalculaArea : MonoBehaviour
{
    public float radio;
    private float resultado;

    void Start()
    {
        
        resultado = Mathf.PI * Mathf.Pow(radio, 2);

        Vector3 scale = transform.localScale;
        scale.x *= radio;
        scale.y *= radio;
        transform.localScale = scale;


        print("Radio:" + radio + "Area:" + resultado);
       
    }

}
