using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{

    public PlayerInventory playerInventory;
    public int itemNum;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Destroy(this.gameObject);
            playerInventory.UpdateInventory(itemNum, true);
        }
    }
}
