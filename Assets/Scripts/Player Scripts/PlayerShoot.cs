﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject fireBullet;


    public void Update()
    {
        ShootBullet();

    }
    void ShootBullet (){
        if (Input.GetKeyDown(KeyCode.F))
        {
            GameObject bullet = Instantiate(fireBullet, transform.position, Quaternion.identity);
            bullet.GetComponent<FireBullet>().Speed *= transform.localScale.x;


        }
    }

    













}// class












