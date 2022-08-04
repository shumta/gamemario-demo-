using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHealth : MonoBehaviour
{
    private Animator anim;
    private int health = 10;
    private int newBossHealth = 10;

    private bool canDamage;

    private Text bossHealthText;

    [SerializeField] AudioSource winGameAudio;

    void Awake()
    {
        anim = GetComponent<Animator>();
        canDamage = true;
    }

    void Start()
    {
        bossHealthText = GameObject.Find("BossText").GetComponent<Text>();
        bossHealthScore.SetActive(false);
    }

    IEnumerator WaitForDamage()
    {
        yield return new WaitForSeconds(2f);
        canDamage = true;
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (canDamage)
        {
            if (target.tag == MyTags.BULLET_TAG)
            {   
                health--;
                canDamage = false;

                if(health <= newBossHealth)
                {
                    bossHealthScore.SetActive(true);
                    bossHealthText.text = "x" + health;
                }
                if (health == 0)
                {
                    GetComponent<BossScript>().DeactivateBossScript();
                    anim.Play("BossDead");

                    winGameAudio.Play();

                    StartCoroutine(WaitForMenu());
                }

                StartCoroutine(WaitForDamage());
            }
        }
    }

    [SerializeField] GameObject resetMenu;
    [SerializeField] GameObject bossHealthScore;

    IEnumerator WaitForMenu()
    {
        yield return new WaitForSeconds(6f);
        resetMenu.SetActive(true);
    }








}//class








    

































