using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float sideForce = 5f;

    void OnEnable()
    {
        float xForce = Random.Range(sideForce, 0);
        float yForce = 0;
        float zForce = Random.Range(sideForce, 0);

        Vector3 force = new Vector3(xForce, yForce, zForce);

        GetComponent<Rigidbody>().velocity = force;
    }

}
