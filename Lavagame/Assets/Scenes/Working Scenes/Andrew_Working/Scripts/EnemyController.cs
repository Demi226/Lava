using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public GameObject[] listOfEnemies;
    public AudioClip[] enemyAudio; 
    public AudioSource enemysource;
    public Transform[] listOfSpawns;
    public int playerLocation = 0;
    public TimmerFunction timerFunction;


    public void UpdateArea()
    {
        timerFunction.UpdateTimer();
        enemysource.PlayOneShot(enemyAudio[playerLocation], 0.7f);
        switch (playerLocation){
            case 1:
                break;
            case 2:
                listOfEnemies[0].SetActive(true);
                break;
            case 3:
                listOfEnemies[0].SetActive(false);
                listOfEnemies[1].SetActive(true);
                break;
            case 4:
                listOfEnemies[1].SetActive(false);
                listOfEnemies[2].SetActive(true);
                break;
            case 5:
                for(int i = 0; i < listOfEnemies.Length; i++)
                {
                    listOfEnemies[i].SetActive(true);
                }
                break;
            default:
                break;
        }
    }
}
