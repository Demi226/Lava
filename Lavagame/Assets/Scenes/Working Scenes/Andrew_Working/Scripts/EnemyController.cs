using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public GameObject[] listOfEnemies;
    public int playerLocation;

    public void UpdateArea()
    {
        switch (playerLocation){
            case 1:
                listOfEnemies[0].SetActive(true);
                break;
            default:
                break;
        }
    }

}
