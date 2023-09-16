using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInventory : MonoBehaviour
{

    public bool hasFood, hasWeapon;
    public Image foodImage, weaponImage;

    public void UpdateInventory(int item, bool toDo)
    {
        switch (item)
        {
            case 1:
                hasFood = toDo;
                break;
            case 2:
                hasWeapon = toDo;
                break;
            default:
                break;
        }   
    }
}
