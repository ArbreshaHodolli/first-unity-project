using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstProgram : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Hello World");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Kodi eshte duke u ekzekutuar " + Time.time);
    }
}
