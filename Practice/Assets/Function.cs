using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Function : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Add(3, 5));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int Add(int a, int b)
    {
        int c = a + b;
        return c;
    }
}
