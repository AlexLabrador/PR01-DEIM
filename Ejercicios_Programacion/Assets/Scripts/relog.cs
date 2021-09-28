using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class relog : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Relog");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Relog()
    {
        int segundos = 0;
        int minutos = 0;
        int horas = 0;
        string textorelog;
        for(int n = 0; ; n++)
        {
            
            segundos++;
            if(segundos > 59)
            {
                minutos++;
                segundos = 0;
               
            }
            if (minutos > 59)
            {
                horas++;
                minutos = 0;
            }

            textorelog = horas + ":" + minutos + ":" + segundos ;
            print(textorelog);
            yield return new WaitForSeconds(1f) ;
        }
           
    }
}
