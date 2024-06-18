using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] int addScore = 100;

    [SerializeField] AudioSource se;
    [SerializeField] AudioClip coin;

    GameManager game;

    bool coinFlag;

    string playerTagName = "Player";
    string gameManagerObjName = "GameManager";
    void Start()
    {
        game = GameObject.Find(gameManagerObjName).GetComponent<GameManager>();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(playerTagName) && !coinFlag)
        {
            se.PlayOneShot(coin);

            game.AddScore(addScore);

            //コインをとった時にスコアが重ならないようにする
            coinFlag = true;

            Destroy(gameObject);
        }
    }
}
