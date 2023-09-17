using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInventory : MonoBehaviour
{

    public GameObject foodImage, weaponImage, boostImage;
    public bool hasFood, hasWeapon, hasBoost;

    public void UpdateInventory(int item)
    {
        switch (item)
        {
            case 0:
                hasFood = !hasFood;
                foodImage.SetActive(hasFood);
                break;
            case 1:
                hasWeapon = !hasWeapon;
                weaponImage.SetActive(hasWeapon);
                break;
            case 2:
                hasBoost = !hasBoost;
                boostImage.SetActive(hasBoost);
                break;
            default:
                break;
        }
    }

    public bool CheckInventory(int item)
    {
        switch (item)
        {
            case 0:
                return (hasFood);
                break;
            case 1:
                return (hasWeapon);
                break;
            case 2:
                return (hasBoost);
                break;
            default:
                return (true);
                break;
        }
    }
}