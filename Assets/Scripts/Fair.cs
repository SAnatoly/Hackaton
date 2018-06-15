using System.Collections;
using System.Collections.Generic;
using UnityEngine; 


public class Fair : MonoBehaviour
{
    public Vector3 spawn;
    GameControler gameController;
    Rigidbody myBody;

    public void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameControler>();
        myBody = GetComponent<Rigidbody>();

    }
    public void Update()
    {
        myBody.AddForce(-30, 0, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Key")
        {
            gameController.key();
            enabled = false;
        }
        if (collision.gameObject.tag == "Key2")
        {
            gameController.key2();
            enabled = false;
        }

    }
}
