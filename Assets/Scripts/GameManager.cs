using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private GameObject ball;
    private int score;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(ball);
        }
    }

    public void IncreaseScore(int increaseNumber)
    {
        score += increaseNumber;
        scoreText.text = "Score:" + score;
    }
}
