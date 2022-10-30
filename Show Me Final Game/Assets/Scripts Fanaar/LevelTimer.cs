using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelTimer : MonoBehaviour
{
    [SerializeField] GameObject Timer;

    float currentTime = 0f;
    float startingTime = 3f;
    void Start()
    {
        currentTime = startingTime;
    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        Timer.GetComponent<TextMeshProUGUI>().text = "" + Mathf.RoundToInt(currentTime) + "";

        if (currentTime <= 0)
        {
            currentTime = 0;
        }
    }
}
