using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeScore : MonoBehaviour
{
    [SerializeField] private TakeBonus _takeBonusHandler;
    [SerializeField] private Text _textScore;
    void Start()
    {
        _textScore.text = "0";
        _takeBonusHandler.BonusTakeHandler += NewScore;
    }

   private void NewScore()
    {
        int currentScore = int.Parse(_textScore.text);
        currentScore += 100;
        _textScore.text = currentScore.ToString();
    }
}
