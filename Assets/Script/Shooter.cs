using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bulletPrefab; // �e��Prefab
    Transform firePoint; // ���ˈʒu

    void Start()
    {
        // ���ˈʒu��ݒ�i���݂̃I�u�W�F�N�g�ʒu����Ɂj
        firePoint = transform;
    }

    void Update()
    {
        // �X�y�[�X�L�[����������e�𔭎�
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // �e�𔭎ˈʒu�ɐ���
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
