using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mat : MonoBehaviour
{
    [SerializeField] float num1 = 0f;
    [SerializeField] float num2 = 0f;
    [SerializeField] string operacion;
    // Start is called before the first frame update
    void Start()
    {
       
            Calculadora(num1, num2, operacion);
       
       
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void Calculadora(float num1, float num2, string operacion)
    {
         float resultado = 0f;
       if( operacion == "dividir")
        {
            resultado = num1 / num2;
            print(resultado);
        }
        

      else if ( operacion == "restar")
        {
            resultado = num1 - num2;
            print(resultado);
        }
        else if (operacion == "sumar")
        {
            resultado = num1 + num2;
            print(resultado);
        }
       else if (operacion == "multiplicar")
        {
            resultado = num1 * num2;
            print(resultado);
        }
        
    }

}
