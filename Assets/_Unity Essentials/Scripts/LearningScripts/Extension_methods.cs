using UnityEngine;
using System.Collections;

public class Extension_methods : MonoBehaviour
{

    void Start()
    {
        transform.ResetTransformation();
    }

    void Update()
    {
        
    }
}

public static class ExtensionMethods
{
    public static void ResetTransformation(this Transform trans)
    {
        trans.position = Vector3.zero;
        trans.localRotation = Quaternion.identity;
        trans.localScale = new Vector3(1, 1, 1);
    }
}