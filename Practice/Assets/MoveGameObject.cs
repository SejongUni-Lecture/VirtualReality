using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGameObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(1.0f,0.0f,0.0f); //.0f 빠른 연산처리
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.forward * Time.deltaTime);
        //transform.Translate(new Vector3(0,1.0f,0) * Time.deltaTime);

        //transform.Translate(new Vector3(1.0f,0,0) * Time.deltaTime);
        transform.Translate(Vector3.right * Time.deltaTime);
    }
}
