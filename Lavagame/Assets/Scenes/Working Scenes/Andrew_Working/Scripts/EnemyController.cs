using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public GameObject[] listOfEnemies;
    public int playerLocation = 0;
    public TimmerFunction timerFunction;

    public void UpdateArea()
    {
        timerFunction.UpdateTimer();
        switch (playerLocation){
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
                listOfEnemies[2].SetActive(false);
                listOfEnemies[0].SetActive(true);
                listOfEnemies[1].SetActive(true);
                break;
            case 6:
                for(int i = 0; i < listOfEnemies.Length; i++)
                {
                    listOfEnemies[i].SetActive(true);
                }
                break;
            case 7:
                //game end here
                break;
            default:
                break;
        }
    }



}
