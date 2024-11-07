using System.Collections;
using System.Collections.Generic;
using GameDevWithMarco.Data;
using GameDevWithMarco.Managers;
using GameDevWithMarco.ObserverPattern;
using GameDevWithMarco.RandomStuff;
using UnityEngine;

namespace GameDevWithMarco.Player
{
    public class CollectCoinsOnTriggerEnter : MonoBehaviour
    {
        [SerializeField] GameEvent coinCollected;
        [SerializeField] GlobalData globalData;
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "Coin")
            {
                int coinValue = collision.GetComponent<Coins>().CoinValue;

                if (globalData != null)
                {
                    globalData.AddToScore(coinValue);  
                }
                else
                {
                    Debug.LogWarning("Global Data SO not assigned to CollectCoinOnTriggerEnter script");
                }

                Destroy(collision.gameObject);
                coinCollected.Raise();
            }
        }

    }
}
