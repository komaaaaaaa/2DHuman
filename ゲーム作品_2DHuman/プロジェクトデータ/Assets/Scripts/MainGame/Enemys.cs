using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemys : MonoBehaviour
{
    //敵のスピード
    [SerializeField] float enemySpeed = 5;
    //カウントの最大値
    [SerializeField] int maxCount = 30;
    // カウンター用
    int count = 0;

    bool flipFlag;

    void Start()
    {
        // カウンターをリセット
        count = 0;
    }

    //一定時間ごとに横移動
    void FixedUpdate()
    {
        transform.Translate(enemySpeed * Time.fixedDeltaTime, 0, 0);
        // カウンターに1を足していく
        count ++;

        // もし、maxCountになったら
        if(count >= maxCount)
        {
            // 180度回転して曲がる
            transform.Rotate(0, 0, 180);
            // カウンターをリセット
            count = 0;
            // 絵が180度回転するので、上下を反転させる
            flipFlag = !flipFlag;

            GetComponent<SpriteRenderer>().flipY = flipFlag;
        }
    }
}
