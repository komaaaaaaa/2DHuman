using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    static ScoreManager I;
    //コインをとった時のスコア
    public static int Score { get; set; }

    string titleSceneName = "Title";
    void Start()
    {
        SceneManager.LoadScene(titleSceneName);
    }

    void Awake()
    {
        if (!I)
        {
            I = this;

            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
