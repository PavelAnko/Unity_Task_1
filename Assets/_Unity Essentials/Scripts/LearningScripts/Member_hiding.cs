using UnityEngine;

public class Member_hiding : MonoBehaviour
{
    void Start()
    {
        Humanoid human = new Humanoid();
        Humanoid enemy = new Enemy();
        Humanoid orc = new Orc();
        human.Yell();
        enemy.Yell();
        orc.Yell();
    }

    void Update()
    {
        
    }
}

public class Humanoid
{
    public void Yell()
    {
        Debug.Log("Humanoid version of the Yell() method");
    }
}

public class Enemy : Humanoid
{
    new public void Yell()
    {
        Debug.Log("Enemy version of the Yell() method");
    }
}

public class Orc : Enemy
{
    new public void Yell()
    {
        Debug.Log("Orc version of the Yell() method");
    }
}
