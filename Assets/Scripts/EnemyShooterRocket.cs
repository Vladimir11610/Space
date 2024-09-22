using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooterRocket : MonoBehaviour
{
    public GameObject rocketPrefab;
    public float shootCooldown = 5f;
    public Transform player;

    void Start()
    {
        InvokeRepeating(nameof(Shoot), 0f, shootCooldown);
    }

    private void Shoot()
    {
        GameObject newRocket = Instantiate(rocketPrefab, transform.position, Quaternion.identity);
        newRocket.GetComponent<MoveRocket>().player = player;
    }
}
