using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_diagonal : MonoBehaviour
{
    float hp = 100;
    public float speed = 3f; // �ړ����x
    public float angle = -55f; // �i�s�����̊p�x�i�x���@�j
    public float timeToDestroy = 10f; // ������܂ł̎��ԁi�b�j
    private Vector3 startPosition; // �����ʒu

    void Start()
    {
        // �����ʒu��ۑ�
        startPosition = transform.position;
        Destroy(gameObject, timeToDestroy);
    }

    void Update()
    {
        {
            // �p�x�����W�A���ɕϊ�
            float angleRad = Mathf.Deg2Rad * angle;

            // X�������̈ړ��ʁicos���g�p�j
            float moveX = Mathf.Cos(angleRad) * speed * Time.deltaTime;

            // Y�������̈ړ��ʁisin���g�p�j
            float moveY = Mathf.Sin(angleRad) * speed * Time.deltaTime;

            // �����Ɋ�Â��Ĉړ�
            transform.Translate(new Vector3(moveX, moveY, 0));
        }
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
