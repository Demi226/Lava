using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MenuBehaviour : MonoBehaviour
{
    public Image startMenu, infoMenu, defeatMenu, endMenu, creditsMenu;
    public GameObject playerObject;
    private float timer = 7f;

    public void GameStart()
    {
        startMenu.enabled = false;
        timer = 7f;
    }

    void Update()
    {
        if(timer > 0f)
        {
            timer -= 1 * Time.deltaTime;
        }
        else
        {
            infoMenu.enabled = false;
            playerObject.SetActive(true);
        }
    }

}
