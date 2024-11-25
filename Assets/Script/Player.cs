using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Charcter
{
    Vector2 moveVec;            //入力された移動方向
    // Start is called before the first frame update
    void Start()
    {
        //キャラクターのスタートの実行
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        //キャラクターのアップデートの実行
        base.Update();

        //入力された移動方向取得
        moveVec = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        //入力された移動方向の単位ベクトル化
        moveVec = moveVec.normalized;
        //入力された移動方向にスピードを掛け移動させる
        transform.position = transform.position + new Vector3(moveVec.x * moveSpeed * Time.deltaTime, moveVec.y * moveSpeed * Time.deltaTime, 0);
    }
}
