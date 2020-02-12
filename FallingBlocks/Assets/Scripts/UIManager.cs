using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOverScreen;
    [SerializeField] private Text ScoreUI;
    private float startTime;

    bool gameOver;

    private void Start()
    {
        FindObjectOfType<PlayerController>().OnPlayerDeath += OnGameOver;
        startTime = Time.time;
    }

    private void Update()
    {
        if(!gameOver)
        {
            ScoreUI.text = Mathf.Floor(Time.time - startTime).ToString();
        }
        else
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(0);
            }
        }
    }
    public void OnGameOver()
    {
        gameOverScreen.SetActive(true);
        gameOver = true;
    }
}
