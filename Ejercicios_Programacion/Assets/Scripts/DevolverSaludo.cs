using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevolverSaludo : MonoBehaviour
{
    [SerializeField] string miNombre;
    // Start is called before the first frame update
    void Start()
    {
        Saludar(miNombre);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   void Saludar(string usuario)
    {
        print("hola " + usuario);
    }
}
