using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomizador : MonoBehaviour
{
    int num;
    bool corriendo = true;
    // Start is called before the first frame update
    void Start()
    {

 
       
    }
    void aleatorio()
    {
        int num = Random.Range(0, 1000);
        print(num);
        if(num == 65)
        {
            corriendo = false;
            print("he encontrado 65");
        }
        
    }
    

    // Update is called once per frame
    void Update()
    {
        if (corriendo == true)
        {
            aleatorio();
        }
        
    }
}
