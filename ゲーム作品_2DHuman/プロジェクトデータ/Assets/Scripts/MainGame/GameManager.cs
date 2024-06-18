using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] Text textscore;
    void Start()
    {
        textscore.text = "Score:" + ScoreManager.Score + "“_";
    }
    public void AddScore(int score)
    {
        ScoreManager.Score += score;
        textscore.text = "Score:" + ScoreManager.Score + "“_";
    }
}
