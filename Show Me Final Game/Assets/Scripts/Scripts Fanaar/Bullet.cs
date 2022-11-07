using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float sideForce = 1f;

    void OnEnable()
    {
        float xForce = 0;
        float yForce = 0;
        float zForce = sideForce;

        Vector3 force = new Vector3(xForce, yForce, zForce);

        GetComponent<Rigidbody>().velocity = force;
    }

}
