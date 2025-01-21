using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    [SerializeField]
    private TextMeshProUGUI text;
    [SerializeField]
    private GameObject gameOverPanel;
    private int coin = 0;

    [HideInInspector]
    public bool isGameOver = false;

    void Awake() {
        if (instance == null) {
            instance = this;
        }
    }

    public void IncreaseCoin() {
        coin += 1;
        text.SetText(coin.ToString());

        if (coin % 30 == 0) {
            Player player = FindObjectOfType<Player>();
            if (player != null) {
                player.Upgrade();
            }
        }
    }

    public void SetGameOver() {
        isGameOver = true;
        
        EnemySpawner enemySpawner = FindObjectOfType<EnemySpawner>();

        if (enemySpawner != null) {
            enemySpawner.StopEnemyRoutine();
        }

        Invoke("ShowGameOverPanel", 1f); // 게임 종료 시 1초 후 저 함수 실행
    }

    public void ShowGameOverPanel() { // 게임 오버 패널 숨겼던거 보이게 하는거
        gameOverPanel.SetActive(true);
    }

    public void PlayAgain() {
        SceneManager.LoadScene("SampleScene"); // SampleScene이란 프로젝트를 만들면 생기는 기초 값
    }
    
}
