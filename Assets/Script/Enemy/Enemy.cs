using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    float hp = 100; // �G�̏���HP
    public float speed = 3f; // �G�̈ړ����x
    public float timeToDestroy = 10f;
    private void Start()
    {
        Destroy(gameObject, timeToDestroy);
    }
    void Update()
    {
        // �������Ɉړ��iX����-�����j
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
    // �_���[�W���󂯂鏈��
    public void TakeDamage(float damage)
    {
        hp-=damage;
        Debug.Log("Enemy HP: " + hp);

        // HP��0�ȉ��Ȃ�G���폜
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}