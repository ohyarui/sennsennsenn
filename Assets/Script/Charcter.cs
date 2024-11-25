using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charcter : MonoBehaviour
{
    [SerializeField] protected　float hp;                 //キャラクターのHP
    [SerializeField] protected　float maxHP;              //キャラクターのMAXHP

    [SerializeField] protected GameObject hpBarMask;      //キャラクターのHPバー
    protected Vector3 hpBarMaskMaxScale;                  //キャラクターのHPバーの最大サイズ

    [SerializeField] protected float moveSpeed;           //キャラクターの移動スピード
    // Start is called before the first frame update
    protected void Start()
    {
        //HPにMAXHPを入れる
        hp = maxHP;
        //HPバーのサイズをHPバーの最大サイズに設定する
        hpBarMaskMaxScale = hpBarMask.transform.localScale;
    }

    // Update is called once per frame
    protected void Update()
    {
        //キャラクターのHPバーの更新
        hpBarMask.transform.localScale = new Vector3(hpBarMaskMaxScale.x * (1 - (hp / maxHP)), hpBarMaskMaxScale.y, hpBarMaskMaxScale.z);
        //テスト用のHP減少コード
        if (Input.GetKeyDown(KeyCode.Space)) hp -= 10.0f;
    }
}
