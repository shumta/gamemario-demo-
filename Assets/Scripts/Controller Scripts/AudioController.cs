using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource gamePlayAudio, jumpAudio, bossShotAudio, winAudio, gameOverAudio;

    // Start is called before the first frame update
    void Start()
    {
        gamePlayAudio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayJumpAudio()
    {
        jumpAudio.Play();
    }
    
    public void PlayBossShotAudio()
    {
        bossShotAudio.Play();
    }

    public void PlayWinAudio()
    {
        winAudio.Play();
    }

    public void PlayGameOverAudio()
    {
        gameOverAudio.Play();
    }





}
