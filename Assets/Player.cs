using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float angularSpeed;
    float x, z;

    void Update()
    {
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * z * Time.deltaTime * speed);
        transform.Rotate(new Vector3(0, x, 0) * Time.deltaTime * angularSpeed);
    }
}
