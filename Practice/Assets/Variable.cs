using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string name;
        name = "Amelia Son";
        Debug.Log(name);

        int age;
        age = 24;
        Debug.Log(name + " is " + age + " years old.");

        age++; //++연산자
        Debug.Log(name + " is " + age + " years old.");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
