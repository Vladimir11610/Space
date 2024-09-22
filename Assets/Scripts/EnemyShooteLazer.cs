using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooterLazer : MonoBehaviour
{
    public GameObject lazerPrefab;
    public float shootCooldown = 5f;

    private void Start()
    {
        InvokeRepeating(nameof(Shoot), 0f, shootCooldown);
    }
    private void Shoot()
    {
        GameObject newLazer = Instantiate(lazerPrefab, transform.position, transform.rotation);
    }
}
