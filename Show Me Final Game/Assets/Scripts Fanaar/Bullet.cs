using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float sideForce = 1f;

    void OnEnable()
    {
        float xForce = Random.Range(-sideForce, sideForce);
        float yForce = 0;
        float zForce = Random.Range(-sideForce, sideForce);

        Vector3 force = new Vector3(xForce, yForce, zForce);

        GetComponent<Rigidbody>().velocity = force;
    }

}
