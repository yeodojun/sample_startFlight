using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 적 내려오게 만들기, 속도 조절
public class Enemy : MonoBehaviour
{
    [SerializeField]
    private GameObject coin;

    [SerializeField]
    private float moveSpeed = 10f;

    private float minY = -7;
    
    [SerializeField]
    private float hp = 1f;

    public void SetMoveSpeed(float moveSpeed) {
        this.moveSpeed = moveSpeed;
    }
    void Update() {
        transform.position += Vector3.down * moveSpeed * Time.deltaTime;
        if (transform.position.y < minY) {
            Destroy(gameObject); // 사라지게 하는 문장

        }
    }

    private void OnTriggerEnter2D(Collider2D other) { // 충돌 처리
        if (other.gameObject.tag == "Weapon") {
            Weapon weapon = other.gameObject.GetComponent<Weapon>();
            hp -= weapon.damage;
            if (hp <= 0) {
                if (gameObject.tag == "Boss") {
                    GameManager.instance.SetGameOver();
                }
                Destroy(gameObject);
                Instantiate(coin, transform.position, Quaternion.identity);
            }
            Destroy(other.gameObject);
        }
    }
}
