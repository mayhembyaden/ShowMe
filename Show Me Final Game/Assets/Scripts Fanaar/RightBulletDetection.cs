using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightBulletDetection : MonoBehaviour
{
    [SerializeField] private Animator AnimationControllerRight;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            AnimationControllerRight.SetBool("PlayRightAnimation", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            AnimationControllerRight.SetBool("PlayRightAnimation", false);
        }
    }

}
