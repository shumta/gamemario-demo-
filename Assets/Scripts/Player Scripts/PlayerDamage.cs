using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerDamage : MonoBehaviour
{
    private Text lifeText;
    private int lifeScoreCount;

    private bool canDamage;

    [SerializeField] AudioSource gameOverAudio;

    void Awake()
    {
        lifeText = GameObject.Find("LifeText").GetComponent<Text>();
        lifeScoreCount = 3;
        lifeText.text = "x" + lifeScoreCount;

        canDamage = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        restartMenu.SetActive(false);
    }

    public void DealDamage()
    {
        if (canDamage)
        {
            lifeScoreCount--;

            if(lifeScoreCount >= 0)
            {
                lifeText.text = "x" + lifeScoreCount;
            }

            if(lifeScoreCount == 0)
            {
                // RESTART THE GAME
                Time.timeScale = 0f;
                RestartMenu();
                gameOverAudio.Play();
                
            }

            canDamage = false;

            StartCoroutine(WaitForDamage());
        }
    }

    IEnumerator WaitForDamage()
    {
        yield return new WaitForSeconds(2f);
        canDamage = true;
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == MyTags.WATER_TAG)
        {
            Time.timeScale = 0f;
            RestartMenu();
            gameOverAudio.Play();
        }
    }

    // Restart UI Script
    [SerializeField] GameObject restartMenu;
    [SerializeField] GameObject turnOffBottom;

    public void RestartMenu()
    {
        restartMenu.SetActive(true);
        turnOffBottom.SetActive(false);

    }
    public void RestartUIGame()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void HomeUIGame()
    {
        SceneManager.LoadScene("MainMenu");
    }




}// class








