using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    public GameObject thePlayer;
    public GameObject charModel;
    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        thePlayer.GetComponent<Move>().enabled = false;
        charModel.GetComponent<Animator>().Play("Stumble Backwar");
    }
}
