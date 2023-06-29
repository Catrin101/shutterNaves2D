using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_MovimientoFondo : MonoBehaviour
{
    public float Velocidad;
    public GameObject ObjDebajo;

    void Start()
    {
        
    }

    void Update()
    {
        if(transform.position.y <= -10){
            transform.position = ObjDebajo.transform.position+new Vector3(0,10,0);
        }
        transform.position += new Vector3(0,Velocidad*Time.deltaTime,0);
    }
}
