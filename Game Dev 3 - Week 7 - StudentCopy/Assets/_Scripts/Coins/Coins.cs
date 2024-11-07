using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDevWithMarco.RandomStuff
{
    public class Coins : MonoBehaviour
    {
        [SerializeField] int coinValue;

        public int CoinValue
        {
            get
            {
                return coinValue;
            }
        }
  
    }
}
