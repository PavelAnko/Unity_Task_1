using UnityEngine;

public class Method_overloading : MonoBehaviour
{    void Start()
    {
        SomeClass myClass = new SomeClass();
        myClass.Add(1, 2);
        myClass.Add("Hello ", "World");
    }

    void Update()
    {
        
    }
}

public class SomeClass
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
