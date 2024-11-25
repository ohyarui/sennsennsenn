using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    static float damageMultiplier = 1f; // �_���[�W�{���i�f�t�H���g: 1�{�j
    float baseDamage = 10f; // �e�̊�{�_���[�W
    float speed = 5f; // �e�̈ړ����x
    float lifetime = 3f; // �e��������܂ł̎���

    void Start()
    {
        // ��莞�Ԍ�ɒe�������I�ɏ���
        Destroy(gameObject, lifetime);
    }

    void Update()
    {
        // �e��O�����i�E�����j�Ɉړ�
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    // �_���[�W�{�����擾���郁�\�b�h
    public static float GetDamageMultiplier()
    {
        return damageMultiplier;
    }

    // �_���[�W�{����ݒ肷�郁�\�b�h
    public static void SetDamageMultiplier(float multiplier)
    {
        damageMultiplier = multiplier;
    }

    // �G�ɓ��������Ƃ��̏���
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            float damage = baseDamage * damageMultiplier;
            Debug.Log("Bullet Damage: " + damage);

            // Enemy��HP�����炷����
            Enemy enemy = collision.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.TakeDamage(damage);
            }

            // �e���폜
            Destroy(gameObject);
        }
    }
}

