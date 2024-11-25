using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    float hp = 100; // 敵の初期HP
    public float speed = 3f; // 敵の移動速度
    public float timeToDestroy = 10f;
    private void Start()
    {
        Destroy(gameObject, timeToDestroy);
    }
    void Update()
    {
        // 左方向に移動（X軸の-方向）
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
    // ダメージを受ける処理
    public void TakeDamage(float damage)
    {
        hp-=damage;
        Debug.Log("Enemy HP: " + hp);

        // HPが0以下なら敵を削除
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}