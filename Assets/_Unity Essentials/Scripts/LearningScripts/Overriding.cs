using UnityEngine;
using System.Collections;

public class Overriding : MonoBehaviour
{
    void Start()
    {
        Apple myApple = new Apple();
        myApple.SayHello();
        myApple.Chop();

        Fruit myFruit = new Apple();
        myFruit.SayHello();
        myFruit.Chop();
    }

    void Update()
    {
        
    }
}

public class Apple : Fruit
{
    public Apple()
    {
        Debug.Log("1st Apple Constructor Called");
    }

    public override void Chop()
    {
        base.Chop();
        Debug.Log("The apple has been chopped.");
    }

    public override void SayHello()
    {
        base.SayHello();
        Debug.Log("Hello, I am an apple.");
    }
}

public class Fruit
{
    public Fruit()
    {
        Debug.Log("1st Fruit Constructor Called");
    }

    public virtual void Chop()
    {
        Debug.Log("The fruit has been chopped.");
    }

    public virtual void SayHello()
    {
        Debug.Log("Hello, I am a fruit.");
    }
}
