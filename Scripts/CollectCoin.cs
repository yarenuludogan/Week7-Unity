using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{

    public AudioSource coinFX;

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        coinFX.Play();
        CollectableControl.coinCount += 1;
        this.gameObject.SetActive(false);
    }
}
