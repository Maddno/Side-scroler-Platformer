using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    [SerializeField] float coinPickedTime = 0.5f;
    [SerializeField] AudioClip coinPickupSFX;
    [SerializeField] int poinysForCoinPickup = 100;

    bool wasCollected = false;


    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player" && !wasCollected)
        {   
            wasCollected = true;
            FindAnyObjectByType<GameSession>().AddToScote(poinysForCoinPickup);
            AudioSource.PlayClipAtPoint(coinPickupSFX, Camera.main.transform.position);
            Destroy(gameObject, coinPickedTime);
        }
    }
}
