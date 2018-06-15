using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void start()
    {
        SceneManager.LoadScene("Start");
    }

    public void exit()
    {
        Application.Quit();
    }
}
