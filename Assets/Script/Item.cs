using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        // �v���C���[�ɐG�ꂽ�����m�F�iPlayer�^�O�𗘗p�j
        if (other.CompareTag("Player"))
        {
            // Bullet�̃_���[�W�{����1.5�{�ɂ���
            bullet.SetDamageMultiplier(bullet.GetDamageMultiplier() * 2.0f);
            Debug.Log("Damage Multiplier: " + bullet.GetDamageMultiplier());

            // �A�C�e�����폜
            Destroy(gameObject);
        }
    }
}

