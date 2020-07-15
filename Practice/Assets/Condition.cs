using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condition : MonoBehaviour
{
    //public int hp = 70;     //유니티 내에서 확인 가능ㄴ

    // Start is called before the first frame update
    void Start()
    {

        //if(hp >= 100)
        //{
        //    Debug.Log("Attack!!");
        //}
        //else if(hp >= 50)
        //{
        //    Debug.Log("Attack and Defense!!");
        //}
        //else
        //{
        //    Debug.Log("Defense!!");
        //}

        int sum = 0;

        for(int i = 0;i < 10; i++ )
        {
            Debug.Log(i);
            sum += i;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
