using UnityEngine;

public class Method_overloading : MonoBehaviour
{    void Start()
    {
        SomeClassLearn myClass = new SomeClassLearn();
        myClass.Add(1, 2);
        myClass.Add("Hello ", "World");
    }

    void Update()
    {
        
    }
}

public class SomeClassLearn
{
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    public string Add(string str1, string str2)
    {
        return str1 + str2;
    }
}
