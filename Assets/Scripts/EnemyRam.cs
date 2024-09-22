using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRam : MonoBehaviour
{
    public Transform playerTransform;
    public float attackDistance = 15f;
    public float maxSpeed = 15f;
    public float attackDiration = 5f;
    public float acceleration = 10f;
    public float delayBeforeAttack = 1f;
    public ParticleSystem Effect;

    public bool isAttaking = false;

    void Update()
    {
        if (isAttaking == false)
        {
            transform.LookAt(playerTransform.position);

            if (Vector3.Distance(transform.position, playerTransform.position) <= attackDistance)
            {
                Attack();
            }
        }
    }

    private void Attack()
    {
        isAttaking = true;
        StartCoroutine(Move(playerTransform.position));
    }

    private IEnumerator Move(Vector3 target)
    {
        yield return new WaitForSeconds(delayBeforeAttack);

        float speed = 0;

        float time = 0;

        Vector3 direction = ( target - transform.position).normalized;

        while (time < attackDiration)
        {
            if (speed < maxSpeed)
            {
                speed += acceleration * Time.deltaTime;
            }

            transform.position += direction * speed * Time.deltaTime;
            time += Time.deltaTime;
            yield return null;
        }
        Instantiate(Effect, transform.position, Quaternion.identity);
        Destroy(gameObject);       
    }
}
