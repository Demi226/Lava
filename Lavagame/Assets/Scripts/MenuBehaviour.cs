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
    public GameObject dummyCamera;


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
            enemyController.enemysource.Stop();
            enemyController.enemysource.Play();
            infoMenu.SetActive(false);
            playerObject.SetActive(true);
            dummyCamera.SetActive(false);
        }

        if(enemyController.playerLocation >= 6)
        {
            enemyController.enemysource.Stop();
            endMenu.SetActive(true);
            dummyCamera.SetActive(true);
            playerObject.SetActive(false);
            endCredits -= 1 * Time.deltaTime;

            enemyController.enemysource.Play();
        }
        if(timerFunction.currentTime <= 0 && timerFunction.gameStart == true)
        {
            enemyController.enemysource.Stop();
            defeatMenu.SetActive(true);
            dummyCamera.SetActive(true);
            playerObject.SetActive(false);
            endCredits -= 1 * Time.deltaTime;

            enemyController.enemysource.Play();
        }
        if(endCredits <= 0f)
        {
            creditsMenu.SetActive(true);
            if (Input.GetKey("r"))
            {
                SceneManager.LoadScene(sceneName);
            }
        }
    }

}
