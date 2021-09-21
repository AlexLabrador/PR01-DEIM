using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contador : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("ContadorCourutine");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator ContadorCourutine()
    { int contador = 0;

        while(true)
        {
            print(contador);
            contador++;
          
            yield return new WaitForSeconds(1f);

                if (contador >= 10)
            {
                
                StopCoroutine("ContadorCourutine");
               
            }


        }
       
    }
}

