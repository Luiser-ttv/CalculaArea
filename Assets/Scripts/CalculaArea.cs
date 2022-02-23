using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalculaArea : MonoBehaviour
{
    public float radio;
    private float resultado;
    public Text MyText;
    private string resultadoTexto;

    void Start()
    {
        float radioCuad = radio * radio;
        resultado = Mathf.PI * radioCuad;
        resultadoTexto = Convert.ToString(resultado);
        MyText.text = resultadoTexto;
    }

   
    void Update()
    {
        
    }
}
