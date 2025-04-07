using UnityEngine;

public class Polymorphism_casting : MonoBehaviour
{
    void Start()
    {
        AnimalLearn myDog = new DogLearn();
        AnimalLearn myCat = new CatLearn();
        myDog.MakeSound();
        myCat.MakeSound();

        if (myDog is DogLearn dog)
        {
            Debug.Log("This is a Dog!");
        }

        if (myCat is CatLearn cat)
        {
            Debug.Log("This is a Cat!");
        }

        RescueShelterLearn shelter = new RescueShelterLearn();
    }

    void Update()
    {

    }
}

public class AnimalLearn
{
    public virtual void MakeSound()
    {
        Debug.Log("Animal makes sound");
    }
}

public class DogLearn : AnimalLearn
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

public class CatLearn : AnimalLearn
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

public class MammalLearn
{
    public void GrowFur()
    {
        Debug.Log("The mammal grows fur.");
    }
}

public class RescueShelterLearn
{
    public AnimalLearn[] mammals;

    public RescueShelterLearn()
    {
        mammals = new AnimalLearn[2];
        mammals[0] = new CatLearn();
        mammals[1] = new DogLearn();

        if (mammals[0] is CatLearn cat)
        {
            cat.Meow();
        }

        if (mammals[1] is DogLearn dog)
        {
            dog.Woof();
        }
    }
}
