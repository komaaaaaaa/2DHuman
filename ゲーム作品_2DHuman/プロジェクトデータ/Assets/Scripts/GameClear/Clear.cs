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
        //�l�������X�R�A��\��
        score_text.text = "Score:" + ScoreManager.Score + "�_";
    }
    private void OnMouseDown()
    {
        ScoreManager.Score = 0;

        SceneManager.LoadScene(titleSceneName);
    }
}
