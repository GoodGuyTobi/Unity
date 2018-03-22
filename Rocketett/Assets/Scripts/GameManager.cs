using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    //Text
    [SerializeField]
    Text t_gameOver;

    [SerializeField]
    float enemySpawnTime,widthOfSpawnPos, spawnTimeLos;

    [SerializeField]
    Transform spawnPos;

    [SerializeField]
    GameObject EnemyPrefab;

    [SerializeField]
    Animator canvasAnim;
    
	void Start () {
        StartCoroutine(SpawnEnemy());
	}

    private void Update()
    {
      
    }

    public void GameOver()
    {
        //Play Game over animator
        canvasAnim.SetBool("GameOver", true);
    }

    IEnumerator SpawnEnemy()
    {
        yield return new WaitForSeconds(enemySpawnTime);
        Debug.Log("Spawn Enemy");

        //Create a spawn position
        Vector3 posToSpawn = new Vector3(Random.Range(-widthOfSpawnPos, widthOfSpawnPos), spawnPos.position.y);

        //Spawn the enemy
        Instantiate(EnemyPrefab, posToSpawn, Quaternion.identity);
        if (enemySpawnTime >= 0)
        {
            enemySpawnTime = enemySpawnTime * spawnTimeLos;
        }
        StartCoroutine(SpawnEnemy());
    }

}
