using UnityEngine;
using System.Collections;

public class Overriding : MonoBehaviour
{
    void Start()
    {
        AppleLearn myApple = new AppleLearn();
        myApple.SayHello();
        myApple.Chop();

        FruitLearn myFruit = new AppleLearn(); // Виправлено з ApplLearne
        myFruit.SayHello();
        myFruit.Chop();
    }

    void Update()
    {

    }
}

public class AppleLearn : FruitLearn
{
    public AppleLearn()
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

public class FruitLearn
{
    public FruitLearn()
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
