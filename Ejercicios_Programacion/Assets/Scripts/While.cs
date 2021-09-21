using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class While : MonoBehaviour
{
    int number = 0;
    // Start is called before the first frame update
    void Start()
    {
      
        while (number <= 10)
        {
            print(number);
            number++;
           
      
            
          


        }
        print("ya ha llegado a 10");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
