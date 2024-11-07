using System.Collections;
using System.Collections.Generic;
using GameDevWithMarco.Managers;
using GameDevWithMarco.RandomStuff;
using UnityEngine;

namespace GameDevWithMarco.Player
{
    public class CollectCoinsOnTriggerEnter : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "Coin")
            {
                int coinValue = collision.GetComponent<Coins>().CoinValue;
                GameManager.Instance.AddToScore(coinValue);
                Destroy(collision.gameObject);
            }
        }

    }
}
