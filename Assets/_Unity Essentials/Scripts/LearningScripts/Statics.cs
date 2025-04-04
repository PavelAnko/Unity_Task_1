using UnityEngine;
using System.Collections;

public class Statics : MonoBehaviour
{
    public static int playerCount = 0;

    void Start()
    {
        Enemy enemy1 = new Enemy();
        Enemy enemy2 = new Enemy();
        Enemy enemy3 = new Enemy();
        int x = Enemy.enemyCount;

        playerCount++;

        int x = Utilities.Add(5, 6);
    }

    void Update()
    {
        
    }
}

public class Enemy
{
    public static int enemyCount = 0;

    public Enemy()
    {
        enemyCount++;
    }
}

public class PlayerManager : MonoBehaviour
{
    void Start()
    {
        int x = Player.playerCount;
    }
}

public static class Utilities
{
    public static int Add(int num1, int num2)
    {
        return num1 + num2;
    }
}


