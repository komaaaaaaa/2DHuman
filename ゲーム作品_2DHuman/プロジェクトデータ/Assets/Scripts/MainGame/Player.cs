using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    const int FRONT_CAMERA = -10;

    [SerializeField] float speed = 5;
    [SerializeField] float jumppower = 7;
    //�v���C���[�ړ���
    float vx = 0;

    // ���������ǂ���
    bool leftFlag;
    // �X�y�[�X�L�[���������ςȂ����ǂ���
    bool pushFlag;
    // �W�����v��Ԃ��ǂ���
    bool jumpFlag;
    // ���������ɐG��Ă��邩�ǂ���
    bool groundFlag;

    string groundTagName = "Ground";
    string returnGameTagName = "ReturnGame";
    string clearTagName = "Clear";
    string mainGame1EnemyTagName = "Enemy";
    string mainGame2EnemyTagName = "Enemy2";
    string nextSceneTagName = "NextGame";
    string clearSceneName = "GameClear";
    string gameOver1SceneName = "GameOver1";
    string gameOver2SceneName = "GameOver2";
    string mainGame2SceneName = "MainGame2";

    [SerializeField] GameObject return_text;

    [SerializeField] AudioSource door_SE;

    Rigidbody2D rbody;
    void Start()
    {
        // �Փˎ��ɉ�]�����Ȃ�
        rbody = GetComponent<Rigidbody2D>();

        rbody.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    void Update()
    {
        vx = 0;

        if(Input.GetKey("d"))
        {
            // �E�ɐi�ވړ��ʂ�����
            vx = speed; 
            leftFlag = false;
        }

        if(Input.GetKey("a"))
        {
            // ���ɐi�ވړ��ʂ�����
            vx = -speed; 
            leftFlag = true;
        }

        if(Input.GetKeyDown("space") && groundFlag)
        {
            if(!pushFlag)
            {
                jumpFlag = true;
                pushFlag = true;
            }
        }
        else
        {
            pushFlag = false;
        }
    }
    void FixedUpdate()
    {
        // �ړ�����i�d�͂��������܂܁j
        rbody.velocity = new Vector2(vx, rbody.velocity.y);

        GetComponent<SpriteRenderer>().flipX = leftFlag;

        if(jumpFlag)
        {
            jumpFlag = false;

            rbody.AddForce(new Vector2(0, jumppower), ForceMode2D.Impulse);
        }
    }
    void LateUpdate()
    {
        Vector3 pos = transform.position;
        // �J�����Ȃ̂Ŏ�O�Ɉړ�������
        pos.z = FRONT_CAMERA;
        Camera.main.gameObject.transform.position = pos;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(mainGame1EnemyTagName))
        {
            ScoreManager.Score = 0;

            SceneManager.LoadScene(gameOver1SceneName);
        }

        if (collision.gameObject.CompareTag(mainGame2EnemyTagName))
        {
            ScoreManager.Score = 0;

            SceneManager.LoadScene(gameOver2SceneName);
        }

        if (collision.gameObject.CompareTag(nextSceneTagName))
        {
            if (door_SE != null)
            {
                door_SE.Play();
            }

            SceneManager.LoadScene(mainGame2SceneName);
        }
        
        if (collision.gameObject.CompareTag(clearTagName))
        {
            SceneManager.LoadScene(clearSceneName);
        }

        if (return_text != null)
        {
            if (collision.gameObject.CompareTag(returnGameTagName))
            {
                return_text.SetActive(true);
            }
            else
            {
                return_text.SetActive(false);
            }
        }
    }
    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(groundTagName))
        {
            groundFlag = true;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        groundFlag = false;
    }
}