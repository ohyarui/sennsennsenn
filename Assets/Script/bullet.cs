using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    static float damageMultiplier = 1f; // ダメージ倍率（デフォルト: 1倍）
    float baseDamage = 10f; // 弾の基本ダメージ
    float speed = 5f; // 弾の移動速度
    float lifetime = 3f; // 弾が消えるまでの時間

    void Start()
    {
        // 一定時間後に弾を自動的に消去
        Destroy(gameObject, lifetime);
    }

    void Update()
    {
        // 弾を前方向（右方向）に移動
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    // ダメージ倍率を取得するメソッド
    public static float GetDamageMultiplier()
    {
        return damageMultiplier;
    }

    // ダメージ倍率を設定するメソッド
    public static void SetDamageMultiplier(float multiplier)
    {
        damageMultiplier = multiplier;
    }

    // 敵に当たったときの処理
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            float damage = baseDamage * damageMultiplier;
            Debug.Log("Bullet Damage: " + damage);

            // EnemyのHPを減らす処理
            Enemy enemy = collision.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.TakeDamage(damage);
            }

            // 弾を削除
            Destroy(gameObject);
        }
    }
}

