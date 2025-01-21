using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private float minY = -7;
    void Start() {
        Jump();
    }

    void Jump() { // 코인 위로 올라갔다가 떨구기
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();

        float randomJumpForce = Random.Range(4f, 8f);
        Vector2 jumpVelocity = Vector2.up * randomJumpForce;
        jumpVelocity.x = Random.Range(-2f, 2f);
        rigidbody.AddForce(jumpVelocity, ForceMode2D.Impulse);
    }

    void Update() {
        if (transform.position.y < minY) {
            Destroy(gameObject); // 사라지게 하는 문장

        }
    }
    
}
