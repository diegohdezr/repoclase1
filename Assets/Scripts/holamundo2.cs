﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class holamundo2 : MonoBehaviour
{
    // Start is called before the first frame update
    private int i = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log("hola "+i);
    }
}
