using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControler : MonoBehaviour
{
    public Text Lose;
    public Text Win;
    public GameObject Door;
    public GameObject Lestnica;
    
    public GameObject spawn;
    /*
    public void fire()
    {
        Instantiate(bul, spawn.transform.position, spawn.transform.rotation);
    }
    */



public void key2()
    {
        Lestnica.transform.Translate( 20, 0, 0);
    }

    public void key()
    {
        Door.transform.Translate(0, 10, 10);
    }

    public void lose()
    {
        Lose.text = "Потеряно";
        Lose.color = Color.red;
        StartCoroutine(Restart());
    }

    public void win()
    {
        Win.text = "Победа";
        Win.color = Color.green;
        StartCoroutine(NextLevel());
    }

    public void win1()
    {
        Win.text = "Победа";
        Win.color = Color.green;
        StartCoroutine(NextLevel1());
    }

    public void win2()
    {
        Win.text = "Победа";
        Win.color = Color.green;
        StartCoroutine(NextLevel2());
    }

    IEnumerator Restart()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    IEnumerator NextLevel()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Level2");
    }

    IEnumerator NextLevel1()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Level3");
    }

    IEnumerator NextLevel2()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Finish");
    }
}
