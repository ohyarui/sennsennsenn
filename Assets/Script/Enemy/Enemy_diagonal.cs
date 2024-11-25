using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_diagonal : MonoBehaviour
{
    float hp = 100;
    public float speed = 3f; // 移動速度
    public float angle = -55f; // 進行方向の角度（度数法）
    public float timeToDestroy = 10f; // 消えるまでの時間（秒）
    private Vector3 startPosition; // 初期位置

    void Start()
    {
        // 初期位置を保存
        startPosition = transform.position;
        Destroy(gameObject, timeToDestroy);
    }

    void Update()
    {
        {
            // 角度をラジアンに変換
            float angleRad = Mathf.Deg2Rad * angle;

            // X軸方向の移動量（cosを使用）
            float moveX = Mathf.Cos(angleRad) * speed * Time.deltaTime;

            // Y軸方向の移動量（sinを使用）
            float moveY = Mathf.Sin(angleRad) * speed * Time.deltaTime;

            // 方向に基づいて移動
            transform.Translate(new Vector3(moveX, moveY, 0));
        }
    }
    public void TakeDamage(float damage)
    {
        hp -= damage;
        Debug.Log("Enemy HP: " + hp);

        // HPが0以下なら敵を削除
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
