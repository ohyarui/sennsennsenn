using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_wave : MonoBehaviour
{
    float hp = 100;
    public float speed = 3f; // “G‚ÌˆÚ“®‘¬“xi¶•ûŒüj
    public float amplitude = 4f; // ã‰ºˆÚ“®‚ÌU•
    public float frequency = 1f; // ã‰ºˆÚ“®‚Ì‘¬‚³iü”g”j
    public float timeToDestroy = 10f;
    private Vector3 startPosition; // ‰ŠúˆÊ’u

    void Start()
    {
        // ‰ŠúˆÊ’u‚ğ•Û‘¶
        startPosition = transform.position;
        Destroy(gameObject, timeToDestroy);
    }

    void Update()
    {
        // ¶•ûŒü‚ÉˆÚ“®
        float horizontalMove = speed * Time.deltaTime;
        transform.Translate(Vector2.left * horizontalMove);

        // ã‰º‚É—h‚ê‚é“®‚«
        float verticalMove = Mathf.Sin(Time.time * frequency) * amplitude;
        transform.position = new Vector3(transform.position.x, startPosition.y + verticalMove, transform.position.z);
    }
    public void TakeDamage(float damage)
    {
        hp -= damage;
        Debug.Log("Enemy HP: " + hp);

        // HP‚ª0ˆÈ‰º‚È‚ç“G‚ğíœ
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
