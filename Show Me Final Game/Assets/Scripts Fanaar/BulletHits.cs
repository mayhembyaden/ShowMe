using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class BulletHits : MonoBehaviour
{
    public GameObject GameOver;
    public GameObject TakenDamage;
    public int Damage;

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Bullet")
        {
            AddToDamage();
            Destroy(other.gameObject);
            Debug.Log("You got hit!");

        }
    }

    public void AddToDamage()
    {
        Damage++;
        TakenDamage.GetComponent<TextMeshProUGUI>().text = "" + Damage + "";

        if (Damage == 1)
        {
            Debug.Log("Game Over");
            GameOver.SetActive(true);
            Invoke("ReturnToMenu", 3.0f);
           
        }
    }

    private void ReturnToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
