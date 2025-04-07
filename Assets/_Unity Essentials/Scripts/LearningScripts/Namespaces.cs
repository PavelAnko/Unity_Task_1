using UnityEngine;
using System;
using System.Collections.Generic; 
using Random = UnityEngine.Random;

public class Skript1 : MonoBehaviour
{
    void Start()
    {
        float speed = Random.value;
        DrawingLearn1 drawing = new DrawingLearn1();
    }

    void Update()
    {
        float vision = Random.value;
    }
}

public class DrawingLearn1
{
    public List<int> items = new List<int>(); 
}
