using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaController : MonoBehaviour
{

    public EnemyController enemyController;

    public Transform gateObject;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            gateObject.SetActive(true);
            enemyController.playerLocation += 1;
            if(enemyController.playerLocation > 1)
            {
                enemyController.UpdateArea();
            }
        }
    }
}
