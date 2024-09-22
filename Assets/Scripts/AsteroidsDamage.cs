using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidsDamage : MonoBehaviour
{
    public int damage = 100;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent<Health>(out Health health))
        {
            health.TakeDamage(damage);
        }
    }
}
