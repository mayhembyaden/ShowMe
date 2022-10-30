using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelTimer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 10f;
    void Start()
    {
        currentTime = 10f;
    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        print(currentTime);
    }
}
