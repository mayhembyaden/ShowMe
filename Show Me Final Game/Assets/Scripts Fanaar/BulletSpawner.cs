using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{

    private void FixedUpdate()
    {
        ObjectPooler.instance.SpawnFromPool("Bullet", transform.position, Quaternion.identity);
    }

}
