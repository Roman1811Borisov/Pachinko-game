using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private int addingScore;
    [SerializeField] private GameManager gameManager;

    private void OnTriggerEnter(Collider other)
    {
        gameManager.IncreaseScore(addingScore);
    }
}
