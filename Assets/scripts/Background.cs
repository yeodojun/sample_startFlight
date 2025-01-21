using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Background : MonoBehaviour { // 배경 무한 생성
// isgameover 함수는 게임 종료 시 배경 멈춤, 미사일 그만 발사, 적 그만 생성
    private float moveSpeed = 3f;
    void Update() {
        transform.position += Vector3.down * moveSpeed * Time.deltaTime;
        if (transform.position.y < -10) {
            transform.position += new Vector3(0, 20f, 0);
        }
    }
    
}