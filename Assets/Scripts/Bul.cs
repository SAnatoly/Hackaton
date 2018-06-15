using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bul : MonoBehaviour {

    GameControler gameController;


    private void Start()
    {

        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameControler>();

    }
    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "Key2")
        {
            gameController.key2();
        }
    }
}
