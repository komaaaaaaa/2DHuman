using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Clear : MonoBehaviour
{
    [SerializeField] Text score_text;

    string titleSceneName = "Title";
    void Start()
    {
        //獲得したスコアを表示
        score_text.text = "Score:" + ScoreManager.Score + "点";
    }
    private void OnMouseDown()
    {
        ScoreManager.Score = 0;

        SceneManager.LoadScene(titleSceneName);
    }
}
