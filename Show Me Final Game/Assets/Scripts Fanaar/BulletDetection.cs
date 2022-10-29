using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDetection : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Bullet Detector Left")
        {
           
            Debug.Log("On your left!");
        }

        if(other.gameObject.tag == "Bullet Detector Right")
        {
            
            Debug.Log("On your Right!");
        }

    }

}
