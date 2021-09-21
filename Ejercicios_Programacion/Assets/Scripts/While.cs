using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class While : MonoBehaviour
{
    float number = 0;
    // Start is called before the first frame update
    void Start()
    {
       while(number >= 10)
        {
            print(number);
            number++;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
