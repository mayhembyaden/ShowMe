using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class LevelTimer : MonoBehaviour
{
    [SerializeField] GameObject Timer;
    public GameObject Score;
    public GameObject Star1;
    public GameObject Star2;
    public GameObject Star3;
    public GameObject hitCount;

    public int Hits;

    float currentTime = 0f;
    float startingTime =90f;
    void Start()
    {
        currentTime = startingTime;
    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        Timer.GetComponent<TextMeshProUGUI>().text = "" + Mathf.RoundToInt(currentTime) + "";
        //hitCount.GetComponent<TextMeshProUGUI>().text = "" + Hits + "";

        if (currentTime <= 0)
        {
            currentTime = 0;
            Score.SetActive(true);
            if(Hits >= 7)
            {
                Star1.SetActive(true);
            }
            else if (Hits >= 4 && Hits < 7)
            {
                Star1.SetActive(true);
                Star2.SetActive(true);
            }
            else if(Hits <= 3)
            {
                Star1.SetActive(true);
                Star2.SetActive(true);
                Star3.SetActive(true);
            }
            //Show end screen with score
            Invoke("ReturnToMainMenu", 5.0f);
        }
    }

    private void ReturnToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
