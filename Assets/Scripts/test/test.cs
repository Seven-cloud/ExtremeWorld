using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Class1 c1 = new Class1();
        int p =  c1.fn(1, 2);
        Debug.Log("方法:"+p);
        Debug.Log("属性:"+ c1.a);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
