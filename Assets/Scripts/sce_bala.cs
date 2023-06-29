﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sce_bala : MonoBehaviour
{
    public float Velocidad;

    void Start()
    {
        Destroy(gameObject,5f);
    }

    void Update()
    {
        transform.position += new Vector3(0,Velocidad*Time.deltaTime,0);

    }

    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.name == "Enemigo"){
            collision.gameObject.GetComponentInParent<scr_enemigo>().Vida -=1;
            Destroy(gameObject);
        }
    }
}
