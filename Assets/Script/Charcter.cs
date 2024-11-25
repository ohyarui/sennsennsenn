using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charcter : MonoBehaviour
{
    [SerializeField] protected�@float hp;                 //�L�����N�^�[��HP
    [SerializeField] protected�@float maxHP;              //�L�����N�^�[��MAXHP

    [SerializeField] protected GameObject hpBarMask;      //�L�����N�^�[��HP�o�[
    protected Vector3 hpBarMaskMaxScale;                  //�L�����N�^�[��HP�o�[�̍ő�T�C�Y

    [SerializeField] protected float moveSpeed;           //�L�����N�^�[�̈ړ��X�s�[�h
    // Start is called before the first frame update
    protected void Start()
    {
        //HP��MAXHP������
        hp = maxHP;
        //HP�o�[�̃T�C�Y��HP�o�[�̍ő�T�C�Y�ɐݒ肷��
        hpBarMaskMaxScale = hpBarMask.transform.localScale;
    }

    // Update is called once per frame
    protected void Update()
    {
        //�L�����N�^�[��HP�o�[�̍X�V
        hpBarMask.transform.localScale = new Vector3(hpBarMaskMaxScale.x * (1 - (hp / maxHP)), hpBarMaskMaxScale.y, hpBarMaskMaxScale.z);
        //�e�X�g�p��HP�����R�[�h
        if (Input.GetKeyDown(KeyCode.Space)) hp -= 10.0f;
    }
}
