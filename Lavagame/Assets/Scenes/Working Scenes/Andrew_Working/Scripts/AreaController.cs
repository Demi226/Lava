using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaController : MonoBehaviour
{

    public EnemyController enemyController;

    public Collider2D triggerBox;

    public GameObject blackout;
    public GameObject gateObject;
    public GameObject thingToHide;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            gateObject.SetActive(true);
            blackout.SetActive(true);
            enemyController.playerLocation += 1;
            triggerBox.enabled = false;
            if(enemyController.playerLocation > 1)
            {
                enemyController.UpdateArea();
            }
            thingToHide.SetActive(false);
        }
    }
}
