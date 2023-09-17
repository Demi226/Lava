using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MenuBehaviour : MonoBehaviour
{
    public GameObject startMenu, infoMenu, defeatMenu, endMenu, creditsMenu;
    public GameObject playerObject;
    public EnemyController enemyController;
    public TimmerFunction timerFunction;
    private float timer = 7f, endCredits = 7f;
    public string sceneName;


    void Awake()
    {
        sceneName = SceneManager.GetActiveScene().name;
    }

    public void GameStart()
    {
        startMenu.SetActive(false);
        infoMenu.SetActive(true);
        timer = 7f;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            GameStart();
        }

        if(timer > 0f && !startMenu.activeSelf)
        {
            timer -= 1 * Time.deltaTime;
        }
        else if(startMenu.activeSelf == false)
        {
            infoMenu.SetActive(false);
            playerObject.SetActive(true);
        }

        if(enemyController.playerLocation >= 6)
        {
            endMenu.SetActive(true);
            playerObject.SetActive(false);
            endCredits -= 1 * Time.deltaTime;
        }
        if(timerFunction.currentTime <= 0 && timerFunction.gameStart == true)
        {
            defeatMenu.SetActive(true);
            playerObject.SetActive(false);
            endCredits -= 1 * Time.deltaTime;
        }
        if(endCredits <= 0f)
        {
            creditsMenu.SetActive(true);
            if (Input.GetKey(KeyCode.Space))
            {
                SceneManager.LoadScene(sceneName);
            }
        }
    }

}
