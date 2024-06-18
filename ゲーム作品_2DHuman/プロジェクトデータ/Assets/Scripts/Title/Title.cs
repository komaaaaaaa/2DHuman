using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    [SerializeField] AudioSource se;

    string prologueSceneName = "Prologue";
    void OnMouseDown()
    {
        se.Play();

        SceneManager.LoadScene(prologueSceneName);
    }
    public void EndButton()
    {
        Application.Quit();
    }
}
