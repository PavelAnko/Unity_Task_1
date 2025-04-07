using UnityEngine;
using System.Collections.Generic;

public interface IDamageableLearn
{
    Vector3 Position { get; }
    void Damage(float damage);
}

public class Interfaces : MonoBehaviour
{
    public float range = 10f;
    public float damage = 35f;
    List<IDamageableLearn> m_AllDamageables = new List<IDamageableLearn>();

    void Start()
    {
        MonoBehaviour[] allScripts = FindObjectsByType<MonoBehaviour>(FindObjectsSortMode.None);
        foreach (MonoBehaviour script in allScripts)
        {
            if (script is IDamageableLearn damageable)
            {
                m_AllDamageables.Add(damageable);
            }
        }
    }

    public void Explode()
    {
        foreach (IDamageableLearn target in m_AllDamageables)
        {
            if (Vector3.Distance(target.Position, transform.position) < range)
            {
                target.Damage(damage);
            }
        }
    }

    void Update()
    {

    }
}

public class PlayerHealthLearn : MonoBehaviour, IDamageableLearn
{
    public float startingHealth = 100f;
    private float m_CurrentHealth;

    public Vector3 Position => transform.position;

    void Start()
    {
        m_CurrentHealth = startingHealth;
    }

    public void Damage(float damage)
    {
        m_CurrentHealth -= damage;
        Debug.Log("Player damaged. Current HP: " + m_CurrentHealth);
    }
}

public class PlayerWithShieldLearn : MonoBehaviour
{
    [SerializeReference]
    public IDamageableLearn shield = new ProtonShieldLearn(Vector3.zero); 
}

public class ProtonShieldLearn : IDamageableLearn
{
    public float hitPoints = 10f;
    private Vector3 _position;

    public ProtonShieldLearn(Vector3 position)
    {
        _position = position;
    }

    public Vector3 Position => _position;

    public void Damage(float damage)
    {
        hitPoints -= damage;
        Debug.Log("Shield took damage. Remaining HP: " + hitPoints);
    }
}
