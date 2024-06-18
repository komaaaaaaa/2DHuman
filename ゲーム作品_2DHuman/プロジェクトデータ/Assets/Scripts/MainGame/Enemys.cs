using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemys : MonoBehaviour
{
    //�G�̃X�s�[�h
    [SerializeField] float enemySpeed = 5;
    //�J�E���g�̍ő�l
    [SerializeField] int maxCount = 30;
    // �J�E���^�[�p
    int count = 0;

    bool flipFlag;

    void Start()
    {
        // �J�E���^�[�����Z�b�g
        count = 0;
    }

    //��莞�Ԃ��Ƃɉ��ړ�
    void FixedUpdate()
    {
        transform.Translate(enemySpeed * Time.fixedDeltaTime, 0, 0);
        // �J�E���^�[��1�𑫂��Ă���
        count ++;

        // �����AmaxCount�ɂȂ�����
        if(count >= maxCount)
        {
            // 180�x��]���ċȂ���
            transform.Rotate(0, 0, 180);
            // �J�E���^�[�����Z�b�g
            count = 0;
            // �G��180�x��]����̂ŁA�㉺�𔽓]������
            flipFlag = !flipFlag;

            GetComponent<SpriteRenderer>().flipY = flipFlag;
        }
    }
}
