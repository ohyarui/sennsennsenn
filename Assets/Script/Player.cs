using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Charcter
{
    Vector2 moveVec;            //���͂��ꂽ�ړ�����
    // Start is called before the first frame update
    void Start()
    {
        //�L�����N�^�[�̃X�^�[�g�̎��s
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        //�L�����N�^�[�̃A�b�v�f�[�g�̎��s
        base.Update();

        //���͂��ꂽ�ړ������擾
        moveVec = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        //���͂��ꂽ�ړ������̒P�ʃx�N�g����
        moveVec = moveVec.normalized;
        //���͂��ꂽ�ړ������ɃX�s�[�h���|���ړ�������
        transform.position = transform.position + new Vector3(moveVec.x * moveSpeed * Time.deltaTime, moveVec.y * moveSpeed * Time.deltaTime, 0);
    }
}
