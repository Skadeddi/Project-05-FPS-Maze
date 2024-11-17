using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class EnemyCounter : MonoBehaviour
{
    private int enemyCount = -1;
    public TextMeshProUGUI counter;
    
    public void SetEnemyCount(int enemyCount)
    {
        this.enemyCount = enemyCount;
        counter.text = this.enemyCount.ToString();
    }

    public void KillEnemy()
    {
        enemyCount--;
        counter.text = enemyCount.ToString();
        if (enemyCount == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }


}
