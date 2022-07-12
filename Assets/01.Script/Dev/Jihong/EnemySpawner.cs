using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    float currenttime=0;
    float spawntime = 1.5f;
    [SerializeField]
    GameObject Enemy;
    [SerializeField]
    GameObject Enemy_Heart;
    void Update()
    {
        //·£´ý Àû »ý¼º 
        currenttime +=Time.deltaTime;
        if(currenttime > spawntime)
        {
            Summon(Random.Range(0,2));  
        }
    }
    void Summon(int forswitch)
    {
        switch (forswitch)
        {
            case 0:
                GameObject enemy = Instantiate(Enemy);
                break;
            case 1:
                GameObject enemy_heart = Instantiate(Enemy_Heart);
                break;
        }
        currenttime = 0;
        spawntime = Random.Range(2f,3f);
    }
}
