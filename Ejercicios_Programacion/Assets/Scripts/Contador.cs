using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contador : MonoBehaviour
{
    bool encendido = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(encendido == false)
            {
                StartCoroutine("ContadorCourutine");
                encendido = true;
            }
            else
            {
                StopCoroutine("ContadorCourutine");
                encendido = false;
            }
            
        }
        



    }

    IEnumerator ContadorCourutine()
    { int contador = 0;

        while(true)
        {
            print(contador);
            contador++;
          
            yield return new WaitForSeconds(1f);

            


        }
       
    }
}

