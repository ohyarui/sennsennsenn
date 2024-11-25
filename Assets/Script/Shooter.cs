using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bulletPrefab; // 弾のPrefab
    Transform firePoint; // 発射位置

    void Start()
    {
        // 発射位置を設定（現在のオブジェクト位置を基準に）
        firePoint = transform;
    }

    void Update()
    {
        // スペースキーを押したら弾を発射
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // 弾を発射位置に生成
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
