using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MenuBehaviour : MonoBehaviour
{
    public GameObject startMenu, infoMenu;// defeatMenu, endMenu, creditsMenu;
    public GameObject playerObject;
    private float timer = 7f;

    public void GameStart()
    {
        startMenu.SetActive(false);
        infoMenu.SetActive(true);
        timer = 7f;
    }

    void Update()
    {
        if(timer > 0f && !startMenu.activeSelf)
        {
            timer -= 1 * Time.deltaTime;
        }
        else if(startMenu.activeSelf == false)
        {
            infoMenu.SetActive(false);
            playerObject.SetActive(true);
        }
    }

}
