using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_wave : MonoBehaviour
{
    float hp = 100;
    public float speed = 3f; // �G�̈ړ����x�i�������j
    public float amplitude = 4f; // �㉺�ړ��̐U��
    public float frequency = 1f; // �㉺�ړ��̑����i���g���j
    public float timeToDestroy = 10f;
    private Vector3 startPosition; // �����ʒu

    void Start()
    {
        // �����ʒu��ۑ�
        startPosition = transform.position;
        Destroy(gameObject, timeToDestroy);
    }

    void Update()
    {
        // �������Ɉړ�
        float horizontalMove = speed * Time.deltaTime;
        transform.Translate(Vector2.left * horizontalMove);

        // �㉺�ɗh��铮��
        float verticalMove = Mathf.Sin(Time.time * frequency) * amplitude;
        transform.position = new Vector3(transform.position.x, startPosition.y + verticalMove, transform.position.z);
    }
    public void TakeDamage(float damage)
    {
        hp -= damage;
        Debug.Log("Enemy HP: " + hp);

        // HP��0�ȉ��Ȃ�G���폜
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
