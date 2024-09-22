using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLazer : MonoBehaviour
{
    public int damage = 10;
    public int speed = 5;
    public float attackDiration = 10f;
    float time = 0;
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
        time += Time.deltaTime;
        if (time > attackDiration ) 
        { 
           Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.TryGetComponent<Health>(out Health health))
        {
            health.TakeDamage(damage);
        }
    }
}
