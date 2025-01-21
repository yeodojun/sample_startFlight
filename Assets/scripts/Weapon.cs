using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 미사일 날리기 무한으로 딜레이 주면서
public class Weapon : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 10f;

    public float damage = 1f;

    void Start() {
        Destroy(gameObject, 0.9f);
    }

    void Update() {
        transform.position += Vector3.up * moveSpeed * Time.deltaTime;

    }
    
}
