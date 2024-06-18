using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Prologue : MonoBehaviour
{
    string playerTagName = "Player";
    string mainGame1SceneName = "MainGame1";
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(playerTagName))
        {
            SceneManager.LoadScene(mainGame1SceneName);
        }
    }
}
