using UnityEngine;
using System.Collections;

public class Generics : MonoBehaviour
{
    void Start()
    {
        GenericClass<int> myClass = new GenericClass<int>();
        myClass.UpdateItem(5);
    }
    void Update()
    {

    }
}

public class SomeClass
{
    public T GenericMethod<T>(T param)
    {
        return param;
    }
}

public class SomeOtherClass : MonoBehaviour
{
    void Start()
    {
        SomeClass myClass = new SomeClass();
        int result = myClass.GenericMethod<int>(5);
        Debug.Log("GenericMethod returned: " + result);
    }
}

public class GenericClass<T>
{
    T item;

    public void UpdateItem(T newItem)
    {
        item = newItem;
        Debug.Log("Updated item to: " + item);
    }
}

