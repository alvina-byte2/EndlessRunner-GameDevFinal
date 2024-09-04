using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    public AudioSource coinfX;

    void OnTriggerEnter(Collider other)
    {
        coinfX.Play();
        this.gameObject.SetActive(false);
    }
}
