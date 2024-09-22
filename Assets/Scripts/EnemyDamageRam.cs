using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageRam : MonoBehaviour
{
    public int damage = 100;
    public ParticleSystem Effect;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent<Health>(out Health health))
        {
            health.TakeDamage(damage);
            Destroy(gameObject);
            Instantiate(Effect, transform.position, Quaternion.identity);
        }
    }
}
