using UnityEngine;
using System.Collections.Generic;

public interface IDamageable
{
    Vector3 Position { get; }
    void Damage(float damage);
}

public class Interfaces : MonoBehaviour
{
    public float range = 10f;
    public float damage = 35f;
    List<IDamageable> m_AllDamageables = new List<IDamageable>();

    void Start()
    {
        MonoBehaviour[] allScripts = FindObjectsOfType<MonoBehaviour>();
        foreach (MonoBehaviour script in allScripts)
        {
            if (script is IDamageable damageable)
            {
                m_AllDamageables.Add(damageable);
            }
        }
    }

    public void Explode()
    {
        foreach (IDamageable target in m_AllDamageables)
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

public class PlayerHealth : MonoBehaviour, IDamageable
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

public class PlayerWithShield : MonoBehaviour
{
    [SerializeReference]
    public IDamageable shield = new ProtonShield(Vector3.zero); 
}

public class ProtonShield : IDamageable
{
    public float hitPoints = 10f;
    private Vector3 _position;

    public ProtonShield(Vector3 position)
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
