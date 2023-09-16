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
            case 1:
                hasFood = !hasFood;
                foodImage.SetActive(hasFood);
                break;
            case 2:
                hasWeapon = !hasWeapon;
                weaponImage.SetActive(hasWeapon);
                break;
            case 3:
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
            case 1:
                return (hasFood);
                break;
            case 2:
                return (weaponImage);
                break;
            case 3:
                return (boostImage);
                break;
            default:
                return (true);
                break;
        }
    }
}