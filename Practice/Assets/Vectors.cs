using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vectors : MonoBehaviour
{
    public Vector2 playerPos = new Vector2(1.0f, 2.0f);
    Vector2 temp;

    // Start is called before the first frame update
    void Start()
    {      
        playerPos.x += 8.0f;       //playerPos.x = playerPos.x + 8.0f
        playerPos.y += 5.0f;
        Debug.Log(playerPos);
    }

    // Update is called once per frame
    void Update()
    {
        //playerPos.x += 0.01f;
        //playerPos.y += 0.02f;

        temp = new Vector2(2.0f, 2.0f);
        playerPos += temp;
    }
       


}
