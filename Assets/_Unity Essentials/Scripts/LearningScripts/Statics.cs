using UnityEngine;
using System.Collections;

public class Statics : MonoBehaviour
{
    public static int playerCount = 0;

    void Start()
    {
        EnemyLearn enemy1 = new EnemyLearn();
        EnemyLearn enemy2 = new EnemyLearn();
        EnemyLearn enemy3 = new EnemyLearn();
        int enemyTotal = EnemyLearn.enemyCount;

        playerCount++;

        int sum = UtilitiesLearn.Add(5, 6);
    }

    void Update()
    {

    }
}

public class EnemyLearn
{
    public static int enemyCount = 0;

    public EnemyLearn()
    {
        enemyCount++;
    }
}

public class PlayerManagerLearn : MonoBehaviour
{
    void Start()
    {
        int x = Statics.playerCount;
    }
}

public static class UtilitiesLearn
{
    public static int Add(int num1, int num2)
    {
        return num1 + num2;
    }
}
