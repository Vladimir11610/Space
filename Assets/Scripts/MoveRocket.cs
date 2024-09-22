using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRocket : MonoBehaviour
{
    public float speed = 5f;
    public int damage = 25;
    public Transform player;
    public float attackDiration = 5f;
    public ParticleSystem ParticleSystem;
    float time = 0f;
    void Update()
    {
        
        transform.LookAt(player);
        transform.position += transform.forward * speed * Time.deltaTime;
        time += Time.deltaTime;
        if (time > attackDiration)
        {
            Instantiate(ParticleSystem, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Health>(out Health currentPlayer))
        {
            currentPlayer.TakeDamage(damage);
            Instantiate(ParticleSystem, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
