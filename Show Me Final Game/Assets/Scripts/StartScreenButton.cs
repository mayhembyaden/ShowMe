using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartScreenButton : MonoBehaviour
{
    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }
}
