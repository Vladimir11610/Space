using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int speed = 10;
    public int speedRotate = 16;
    private float horizontal;
    private float vertical;
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        transform.position += transform.forward * speed * Time.deltaTime;
        transform.Rotate(transform.up * speedRotate * Time.deltaTime * horizontal);
        transform.Rotate(Vector3.right * speedRotate * Time.deltaTime * vertical * -1);

    }
}
