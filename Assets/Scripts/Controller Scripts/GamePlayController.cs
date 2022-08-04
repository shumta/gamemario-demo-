using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GamePlayController : MonoBehaviour
{   
    // Pause Menu Script
    [SerializeField] GameObject pauseMenu;

    void Start()
    {
        pauseMenu.SetActive(false);
    }
    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void Home()
    {
        SceneManager.LoadScene("MainMenu");
    }

    




}// class






