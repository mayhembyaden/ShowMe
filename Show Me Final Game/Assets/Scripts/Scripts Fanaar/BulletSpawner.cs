using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    private void Start()
    {
        ObjectPooler.instance.SpawnFromPoolRepeat("Bullet", transform.position, Quaternion.identity, 1000);
    }
}
