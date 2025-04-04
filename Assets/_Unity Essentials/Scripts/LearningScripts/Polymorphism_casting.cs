using UnityEngine;

public class Polymorphism_casting : MonoBehaviour
{
    void Start()
    {
        Animal myDog = new Dog();
        Animal myCat = new Cat();
        myDog.MakeSound();  
        myCat.MakeSound();  

        if (myDog is Dog dog)
        {
            Debug.Log("This is a Dog!");
        }

        if (myCat is Cat cat)
        {
            Debug.Log("This is a Cat!");
        }

        RescueShelter shelter = new RescueShelter();
    }

    void Update()
    {
        
    }
}

public class Animal : MonoBehaviour
{
    public virtual void MakeSound()
    {
        Debug.Log("Animal makes sound");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Debug.Log("Bark!");
    }

    public void Woof()
    {
        Debug.Log("Woof! Woof!");
    }
}

public class Cat : Animal
{
    public override void MakeSound()
    {
        Debug.Log("Meow!");
    }

    public void Meow()
    {
        Debug.Log("Meow! Meow!");
    }
}

public class Mammal
{
    public void GrowFur()
    {
        Debug.Log("The mammal grows fur.");
    }
}

public class RescueShelter
{
    public Mammal[] mammals;

    public RescueShelter()
    {
        mammals = new Mammal[2];
        mammals[0] = new Cat();  
        mammals[1] = new Dog(); 

        if (mammals[0] is Cat cat)
        {
            cat.Meow();  
        }

        if (mammals[1] is Dog dog)
        {
            dog.Woof(); 
        }
    }
}