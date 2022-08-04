﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggScript : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D target)
    {
        if(target.gameObject.tag == MyTags.PLAYER_TAG)
        {
            // Damege the player
            target.gameObject.GetComponent<PlayerDamage>().DealDamage();
        }
        gameObject.SetActive(false);
    }

}
