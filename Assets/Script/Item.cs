using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        // プレイヤーに触れたかを確認（Playerタグを利用）
        if (other.CompareTag("Player"))
        {
            // Bulletのダメージ倍率を1.5倍にする
            bullet.SetDamageMultiplier(bullet.GetDamageMultiplier() * 2.0f);
            Debug.Log("Damage Multiplier: " + bullet.GetDamageMultiplier());

            // アイテムを削除
            Destroy(gameObject);
        }
    }
}

