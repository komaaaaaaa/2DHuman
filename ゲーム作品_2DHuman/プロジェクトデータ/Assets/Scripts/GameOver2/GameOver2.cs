using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver2 : MonoBehaviour
{
    AudioSource replay_SE;

    string mainGame2NameScene = "MainGame2";
    void Start()
    {
        replay_SE = GetComponent<AudioSource>();
    }
    void OnMouseDown()
    {
        replay_SE.Play();

        SceneManager.LoadScene(mainGame2NameScene);
    }
}
