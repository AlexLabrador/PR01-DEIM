using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calcular : MonoBehaviour
{
    [SerializeField] float num1 = 0f;
    [SerializeField] float num2 = 0f;
    private float resultado;
    // Start is called before the first frame update
    void Start()
    {
        resultado = num1 + num2 * num2;
        print(resultado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
