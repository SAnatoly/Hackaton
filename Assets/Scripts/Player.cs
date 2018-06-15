using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed;
    public float speedRotate;
    public float jump;
    public GameObject bul;
    public GameObject spawn;

    GameControler gameController;

	void Start ()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameControler>();
	}
	
	
	void Update ()
    {
        Vector3 spawnCoords = spawn.transform.position;
        float mowX = 0;
        float mowZ = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float rotate = Input.GetAxis("Horizontal") * speedRotate * Time.deltaTime;

        if (Input.GetButtonDown("Jump"))
        {
            mowX = jump * Time.deltaTime;
        }
    

        transform.Translate(0, mowX, mowZ);
        transform.Rotate(0, rotate, 0);

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bul, spawnCoords, Quaternion.identity);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            gameController.lose();
            enabled = false;
        }

        if(collision.gameObject.tag == "Key")
        {
            gameController.key();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Win")
        {
            gameController.win();
            enabled = false;
        }

        if (other.gameObject.tag == "Win1")
        {
            gameController.win1();
            enabled = false;
        }

        if (other.gameObject.tag == "Win2")
        {
            gameController.win2();
            enabled = false;
        }
    }
}
