using UnityEngine;
using System.Collections;
using System;
using Random = UnityEngine.Random;

public class Skript1 : MonoBehaviour
{

    void Start()
    {
        float speed = Random.value;
        Drawing drawing = new Drawing();    
    }

    void Update()
    {
        float vision = Random.value;
    }
}

public class Drawing
{
    public System.Collections.List<Item> items;
}
