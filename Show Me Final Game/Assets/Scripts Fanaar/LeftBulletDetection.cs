using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftBulletDetection : MonoBehaviour
{
    [SerializeField] private Animator AnimationControllerLeft;

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Bullet"))
        {
            AnimationControllerLeft.SetBool("PlayLeftAnimation", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            AnimationControllerLeft.SetBool("PlayLeftAnimation", false);
        }
    }
}
