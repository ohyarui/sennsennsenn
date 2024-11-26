using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_wave : MonoBehaviour
{
    float hp = 100;
    public float speed = 3f; // 敵の移動速度（左方向）
    public float amplitude = 4f; // 上下移動の振幅
    public float frequency = 1f; // 上下移動の速さ（周波数）
    public float timeToDestroy = 10f;
    private Vector3 startPosition; // 初期位置

    void Start()
    {
        // 初期位置を保存
        startPosition = transform.position;
        Destroy(gameObject, timeToDestroy);
    }

    void Update()
    {
        // 左方向に移動
        float horizontalMove = speed * Time.deltaTime;
        transform.Translate(Vector2.left * horizontalMove);

        // 上下に揺れる動き
        float verticalMove = Mathf.Sin(Time.time * frequency) * amplitude;
        transform.position = new Vector3(transform.position.x, startPosition.y + verticalMove, transform.position.z);
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
