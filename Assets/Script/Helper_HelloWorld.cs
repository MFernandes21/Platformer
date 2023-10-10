using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helper_HelloWorld : MonoBehaviour
{

    private void Start()
    {
        
    }
    private void Update()
    {
        
    }
    public void HelloWorld()
    {
        if (Input.GetKey(KeyCode.H) == true)
        {
            Debug.Log("Hello World");
        }
    }
}
