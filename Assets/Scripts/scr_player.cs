using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scr_player : MonoBehaviour
{
    public Vector3 Movimiento;
    public float Velocidad;
    public GameObject bala;
    public float Timer,tiempoEspera;
    public int puntos;
    public Text puntuacion;

    void Start()
    {
        
    }

    void Update()
    {
        Movimiento = new Vector3(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"),0);
        Movimiento = Movimiento.normalized;
        transform.position += Movimiento*Velocidad*Time.deltaTime;
        if(Input.GetKey("space") && Timer <= 0){
            Instantiate(bala,transform.position,Quaternion.Euler(0,0,90));
            Timer = tiempoEspera;
        }
        Timer -= Time.deltaTime;
        puntuacion.text = puntos.ToString("");
    }
    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.name=="Enemigo"){
            SceneManager.LoadScene("juego");
        }
    }
}
