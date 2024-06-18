using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver1 : MonoBehaviour
{
    AudioSource replay_SE;

    string mainGame1SceneName = "MainGame1";
    void Start()
    {
        replay_SE = GetComponent<AudioSource>();
    }

    void OnMouseDown()
    {
        replay_SE.Play();
        SceneManager.LoadScene(mainGame1SceneName);
    }
}
