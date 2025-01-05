using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameDevWithMarco.Singleton;
using GameDevWithMarco.Data;
using UnityEngine.SceneManagement;

namespace GameDevWithMarco.Managers
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] GlobalData globalData;

        private void Start()
        {
            if (globalData != null)
            {
                globalData.ResetsScore();
                globalData.SetTheScoreRequiredToWin();
            }
            else
            {
                Debug.LogWarning("The Global Data SO has not been assigned to the Game Manager");
            }
        }

        public void GameWon()
        {
            Time.timeScale = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        private int score;

        public int Score
        {
            get
            {
                return score;
            }
        }

        public void AddToScore(int numberToAdd)
        {
            score += numberToAdd;
            Debug.Log($"The current score is {score}");
        }
 
    }
}
