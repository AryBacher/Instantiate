using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneObject : MonoBehaviour
{
    int num1 = 0;
    public GameObject ObjectToClone;  

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Instantiateobject()
    {
        while (num1 < 3)
        {
            Instantiate(ObjectToClone);
            num1 += 1;
        }

        num1 = 0;
    }
}
