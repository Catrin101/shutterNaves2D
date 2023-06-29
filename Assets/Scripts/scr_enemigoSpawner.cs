using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_enemigoSpawner : MonoBehaviour
{
    public GameObject enemigo;
    public float Timer,tiempoEspera;

    void Start()
    {
        
    }

    void Update()
    {
        if(Timer <=0){
            Instantiate(enemigo,new Vector3(0,0,0),Quaternion.Euler(0,0,0));
            Timer = tiempoEspera;
        }
        Timer -=Time.deltaTime;
    }
}
